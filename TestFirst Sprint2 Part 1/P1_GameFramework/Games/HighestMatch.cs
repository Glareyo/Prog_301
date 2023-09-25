using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static P1_GameFramework.UIUtility;


namespace P1_GameFramework.Games
{
    internal class HighestMatch : Game
    {
        //Specific Variables
        Player player;
        Player dealer; //The NPC

        //Scores
        int playerScore = 0;
        int dealerScore = 0;

        //Dealer's Target Score for AI
        int dealersTargetScore = 35;

        //Decks
        const int DISCARD = 0;
        const int MAIN = 1;

        //Point Systems
        const int PLAYER_SCORE = 0;
        const int DEALER_SCORE = 1;

        public HighestMatch(string _title) : base(_title)
        {
            decks.Add(new Deck("Discard", 0, 0));
            decks.Add(new Deck("Main", 4, 13));
            points.Add(new PointSystem("Player Score", 0));
            points.Add(new PointSystem("Dealer's Score", 0));

            player = new Player(playerName);
            dealer = new Player("Dealer");

            

            instructions = new string[]
            {
                "Goal: Get the highest possible value via matching suits",
                "The game will run for 10 rounds",
                "Each round, your can either",
                "",
                " - Swap a card, via discarding one and drawing from the deck, ",
                "OR",
                " - Compare your hand to the dealer’s hand",
                "",
                "The dealer will be either swapping a card or standing each round",
                "",
                "The goal is to get the highest value possible under the same suits",
                "Example: 4 of club, 5 of club, 2 of diamond, Ace of spade. Highest value is 4+5 of club = 9",
                "",
                "Note: Ace = 1, Jacks = 11, Queens = 12, Kings = 13"
            };
        }


        public override void PlayGame()
        {
            Console.Clear();
            base.PlayGame();
            int round = 1;
            int maxRounds = 10;

            bool running = true;

            //Deck deals 4 cards to player,
            player.DrawCard(decks[MAIN], 4, 0);
            //then 4 cards to dealer.
            dealer.DrawCard(decks[MAIN], 4, 0);

            CenterString("The cards have been drawn...", ConsoleColor.Magenta);
            Console.WriteLine();

            Continue();
            while (running)
            {
                ///Menu Prompting
                //Display player's cards in Unicode style ---> DisplayCards(player).
                string[] cardLines = GetCardDisplays(player.GetHand);
                string[] prompts =
                {
                    $"Number of Cards in Main: {decks[MAIN].cards.Count}",
                    "------------------------------", //-3
                    $"Round {round}/{maxRounds}",//-2
                    "------------------------------", //=1
                    "Here are your cards...", //0
                    "", //1
                    cardLines[0], //2
                    cardLines[1], //3
                    cardLines[2], //4
                    cardLines[3], //5
                    cardLines[4], //6
                    cardLines[5], //7
                    $"{TotalUpPoints(player.GetHand,ref playerScore)}",//8
                    "", //9
                    "What do you want to do?" //10
                };
                ConsoleColor[] colors =
                {
                    ConsoleColor.Red,
                    ConsoleColor.Green, //-3
                    ConsoleColor.Green, //-2
                    ConsoleColor.Green, //-1
                    ConsoleColor.Magenta, //0
                    ConsoleColor.White, //1
                    ConsoleColor.Cyan, //2
                    ConsoleColor.Cyan, //3
                    ConsoleColor.Cyan, //4
                    ConsoleColor.Cyan, //5
                    ConsoleColor.Cyan, //6
                    ConsoleColor.Cyan, //7
                    ConsoleColor.Yellow,//8
                    ConsoleColor.White, //9
                    ConsoleColor.Green //10
                };
                string[] options =
                {
                    "Draw a card",
                    "Compare Hands"
                };
                // -- Menu Prompt (Switch)
                //1. - Draw a card    ---> New Method --> SwapCardOption()
                // +1 to rounds
                //2. - Compare Hands  ---> EndGame

                int swappedCard = -1;
                switch (MenuPrompt(prompts, colors, options))
                {
                    case 1:
                        swappedCard = SwapCardMenu();
                        round++;
                        break;
                    case 2:
                        running = false;
                        break;
                }
                if (swappedCard != -1)
                {
                    player.SwapACard(decks[DISCARD], decks[MAIN], swappedCard);
                    Console.WriteLine();
                    CenterString("-------------------------------", ConsoleColor.Green);
                    CenterString("Drawn Card:");

                    foreach (string s in GetSingleCardDisplay(player.GetHand[swappedCard]))
                    {
                        CenterString(s, ConsoleColor.Red);
                    }
                    Continue();
                }

                ///Dealer NPC
                DealerAI();
                //Random check to select a card or stay.


                //If round >= maxRounds ---> Endgame.
                if (round > maxRounds) running = false;
            }

            EndGame();
        }


        void DealerAI()
        {
            // 1. Check all cards.
            // See what is the highest suit and what is the lowest suit count via strings, only if it is over 0.
            string highestSuit = ""; //Highest Suit
            
            //Determine high / low suit
            string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };

            int[] cardSuitCount =
            {
                0, //Diamonds
                0, //Spades
                0, //Clubs
                0 //Hearts
            };

            foreach (Card card in dealer.GetHand)
            {
                if (card.suit == suits[0]) cardSuitCount[0] += card.value;
                else if (card.suit == suits[1]) cardSuitCount[1] += card.value;
                else if (card.suit == suits[2]) cardSuitCount[2] += card.value;
                else if (card.suit == suits[3]) cardSuitCount[3] += card.value;
            }



            //Determine Highest Suit
            int highestSuitCount = -1;

            for(int i = 0; i < cardSuitCount.Length; i++)
            {
                if (cardSuitCount[i] > 0)
                {
                    if (cardSuitCount[i] > highestSuitCount)
                    {
                        highestSuitCount = cardSuitCount[i];
                        highestSuit = suits[i];
                    }
                }
            }


            //If the dealer's goal is not met, swap a card.
            TotalUpPoints(dealer.GetHand, ref dealerScore);
            if (dealerScore < dealersTargetScore)
            {
                DealerSwapsCards(highestSuit);
            }
        }

        void DealerSwapsCards(string highestSuit)
        {

            //Determine possible cards to swap
            List<Card> possibleCards = new List<Card>();
            foreach(Card card in dealer.GetHand)
            {
                if (card.suit != highestSuit) possibleCards.Add(card);
            }


            //Target Card to discard
            Card targetCard = dealer.GetHand[0]; //Get the very first card to see as a base.


            //If there are cards of different suits
            if (possibleCards.Count > 0)
            {
                //Randomly select from possible cards.
                targetCard = possibleCards[rand.Next(possibleCards.Count)];
            }
            //Swap based on lowest number
            else
            {
                int lowestValue = targetCard.value;
                foreach (Card card in dealer.GetHand)
                {
                    if (card.value < lowestValue)
                    {
                        targetCard = card;
                        lowestValue = card.value;
                    }
                }
            }

            //Remove possible card from hand.
            dealer.DiscardCard(decks[DISCARD], targetCard);
            //Draw a new card.
            dealer.DrawCard(decks[MAIN], 1, 0);

        }


        string[] GetSingleCardDisplay(Card card)
        {
            // Help gotten via Youtube Video
            // "How to print Unicode text on console window using C#" by ProgrammerTube, Youtube
            //https://www.youtube.com/watch?v=rTqBnJ8HrSc

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string[] result = new string[6];


            //Utilizing Unicode Table from Symbl
            //https://symbl.cc/en/
            string[] suitSymbols = { "♦", "♠" , "♣" , "♥" };

            string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };

            string[] rankSymbols = { "A", "J", "Q", "K" };
            string[] rankTypes = { "Ace", "Jack", "Queen", "King" };

            string suitSymbol = "";
            string faceSymbol = $"{card.value}";

            for(int i = 0; i < suits.Length; i++)
            {
                if (card.suit == suits[i]) suitSymbol = suitSymbols[i];
                if (card.rank == rankTypes[i]) faceSymbol = rankSymbols[i];
            }

            string topOfCard = $"";
            string bottomOfCard = $"";


            if (faceSymbol == "10")
            {
                topOfCard = $"|{faceSymbol}{suitSymbol}   |";
                bottomOfCard = $"|   {faceSymbol}{suitSymbol}|";
            }
            else
            {
                topOfCard += $"|{faceSymbol}{suitSymbol}    |";
                bottomOfCard += $"|    {faceSymbol}{suitSymbol}|";
            }


            result[0] = ($"+------+");
            result[1] = ($"{topOfCard}");
            result[2] = ($"|      |");
            result[3] = ($"|      |");
            result[4] = ($"{bottomOfCard}");
            result[5] = ($"+------+");

            return result;
        }
        string[] GetCardDisplays(List<Card> cards)
        {
            // CREDIT
            // Help gotten via Youtube Video
            // "How to print Unicode text on console window using C#" by ProgrammerTube, Youtube
            //https://www.youtube.com/watch?v=rTqBnJ8HrSc

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string[] result = new string[6];

            

            // CREDIT
            //Utilizing Unicode Table from Symbl
            //https://symbl.cc/en/
            
            string diamond = "♦";
            string spade = "♠";
            string club = "♣";
            string heart = "♥";


            string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };
            string[] rankTypes = { "Ace", "Jack", "Queen", "King" };

            string[] cardSymbols = new string[4];
            string[] cardRank = new string[4];

            for (int i = 0; i < cardSymbols.Length; i++)
            {
                if (cards[i].suit == suits[0]) cardSymbols[i] = diamond;
                else if (cards[i].suit == suits[1]) cardSymbols[i] = spade;
                else if (cards[i].suit == suits[2]) cardSymbols[i] = club;
                else if (cards[i].suit == suits[3]) cardSymbols[i] = heart;

                if (cards[i].rank == rankTypes[0]) cardRank[i] = "A";
                else if (cards[i].rank == rankTypes[1]) cardRank[i] = "J";
                else if (cards[i].rank == rankTypes[2]) cardRank[i] = "Q";
                else if (cards[i].rank == rankTypes[3]) cardRank[i] = "K";
                else cardRank[i] = cards[i].rank;
            }

            string topOfCard = $"";
            string bottomOfCard = $"";
            for (int i = 0; i < cardRank.Length; i++)
            {
                //Store card info
                if (cardRank[i] == "10")
                {
                    topOfCard += $"  |{cardRank[i]}{cardSymbols[i]}   |";
                    bottomOfCard += $"  |   {cardRank[i]}{cardSymbols[i]}|";
                }
                else
                {
                    topOfCard += $"  |{cardRank[i]}{cardSymbols[i]}    |";
                    bottomOfCard += $"  |    {cardRank[i]}{cardSymbols[i]}|";
                }
            }
            

            result[0] = ($"  +------+  +------+  +------+  +------+ ");
            result[1] = ($"{topOfCard}");
            result[2] = ($"  |      |  |      |  |      |  |      | ");
            result[3] = ($"  |      |  |      |  |      |  |      | ");
            result[4] = ($"{bottomOfCard}");
            result[5] = ($"  +------+  +------+  +------+  +------+ ");

            return result;
        }

        int SwapCardMenu()
        {// Specialized menu system for drawing cards
         //Player only
            int currentOpt = 0;
            bool runMenu = true;
            string[] cardLines = GetCardDisplays(player.GetHand);

            for(int i = 0; i < cardLines.Length; i++)
            {
                cardLines[i] = CreateCenStr(cardLines[i], true);
            }


            while (runMenu)
            {
                Console.Clear();
                CenterString("Select a card to swap...", ConsoleColor.Green);
                CenterString("_________________________________________", ConsoleColor.Green);
                Notify("\'RIGHT\' / \'LEFT\' : select.");
                Notify("\'Enter\' : Confirm.");
                CenterString("_________________________________________", ConsoleColor.Green);

                //Write lines of cards
                for(int i = 0; i < cardLines.Length; i++)
                {//Check each line / container of the cardLines
                    bool drawingCard = false; //Checks to see if a card is currently being drawn ---> Searches for the '|' symbol.
                    bool drawSelectedCard = false;
                    int targetCardNum = 0;
                    for(int x = 0; x < cardLines[i].Length; x++)
                    {//Check each char in the card line
                        if ((drawingCard == false && cardLines[i][x] == '|') || (drawingCard == false && cardLines[i][x] == '+'))
                        {
                            drawingCard = true; //Currently in a card.
                        }
                        else if ((drawingCard == true && cardLines[i][x] == '|') || (drawingCard == true && cardLines[i][x] == '+'))
                        {
                            drawingCard = false; //Currently out of card.
                            targetCardNum++;
                        }
                        //Check to see if the target selected card is currently being drawn
                        if (drawingCard == true && targetCardNum == currentOpt)
                        {// Highlight selected card
                            drawSelectedCard = true;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else if (drawSelectedCard == true)
                        {
                            drawSelectedCard = false;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {//Don't highlight selected card.
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }

                        //Draw Char
                        Console.Write(cardLines[i][x]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }

                string playerInput = Console.ReadKey().Key.ToString();

                if (playerInput == ConsoleKey.LeftArrow.ToString())
                    currentOpt--; 
                else if (playerInput == ConsoleKey.RightArrow.ToString())
                    currentOpt++;
                else if (playerInput == ConsoleKey.Enter.ToString())
                    runMenu = false;

                if (currentOpt <= 0) currentOpt = 0;
                else if (currentOpt >= player.GetHand.Count) currentOpt = player.GetHand.Count - 1;
            }



            return currentOpt;
        }



        string TotalUpPoints(List<Card> target, ref int targetPoints)
        {
            string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };

            List<Card> diamonds = new List<Card>();
            List<Card> spades = new List<Card>();
            List<Card> clubs = new List<Card>();
            List<Card> hearts = new List<Card>();

            //Add card to associated list.
            foreach(Card card in target)
            {
                if (card.suit == suits[0]) diamonds.Add(card);
                if (card.suit == suits[1]) spades.Add(card);
                if (card.suit == suits[2]) clubs.Add(card);
                if (card.suit == suits[3]) hearts.Add(card);
            }

            int[] points =
            {
                CountCards(diamonds),
                CountCards(spades),
                CountCards(clubs),
                CountCards(hearts),
            };



            int highestMatchPoints = 0;
            string highestMatchSuit = "";
            for(int i = 0; i < points.Length; i++)
            {
                if (points[i] >= highestMatchPoints)
                {
                    highestMatchPoints = points[i];
                    highestMatchSuit = suits[i];
                }
            }
            targetPoints = highestMatchPoints;


            return $"Highest Match: {highestMatchPoints} of {highestMatchSuit}";
        }
        int CountCards(List<Card> list)
        {
            int total = 0;

            foreach(Card card in list)
            {
                total += card.value;

            }
            return total;
        }
        void EndGame()
        {

            //Print all information
            Console.Clear();
            CenterString("----------------------------", ConsoleColor.Green);
            CenterString("Ending Game",ConsoleColor.Green);
            CenterString("----------------------------", ConsoleColor.Green);
            Console.WriteLine();
            
            CenterString("Your Hand: ", ConsoleColor.Cyan);
            foreach (string s in GetCardDisplays(player.GetHand))
                CenterString(s, ConsoleColor.Cyan);
            CenterString(TotalUpPoints(player.GetHand, ref playerScore), ConsoleColor.Cyan);
            CenterString("----------------------------", ConsoleColor.Cyan);
            Console.WriteLine();

            CenterString("Dealer's Hand: ", ConsoleColor.Red);

            foreach (string s in GetCardDisplays(dealer.GetHand))
                CenterString(s, ConsoleColor.Red);
            CenterString(TotalUpPoints(dealer.GetHand, ref dealerScore), ConsoleColor.Red);
            CenterString("----------------------------", ConsoleColor.Red);
            Console.WriteLine();

            if (dealerScore > playerScore)
            {
                CenterString($"The dealer has {dealerScore - playerScore} more points.", ConsoleColor.Red);
                CenterString($"The dealer has WON.", ConsoleColor.Red);
            }
            else if (dealerScore < playerScore)
            {
                CenterString($"You have {playerScore - dealerScore} more points.", ConsoleColor.Cyan);
                CenterString($"You have WON.", ConsoleColor.Cyan);
            }
            else
            {
                CenterString($"You and the dealer both have {playerScore} points.", ConsoleColor.Green);
                CenterString($"You and the dealer are TIED", ConsoleColor.Green);
            }
            Console.WriteLine();
            Continue();
        }



    }
}
