using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static P1_GameFramework.UIUtility;

namespace P1_GameFramework.Games
{
    internal class ApplesOrOranges : Game
    {
        enum deckPile : int
        {
            discard = 0,
            main = 1
        };
        enum pointSystem
        {
            playerPoints = 0,
        };

        public ApplesOrOranges(string _title) : base(_title)
        {
            decks.Add(new Deck("Discard", 0, 0));
            decks.Add(new Deck("Main", 2, 13));
            points.Add(new PointSystem("Score", 0));

            instructions = new string[]
            {
                "The Game plays 13 Rounds.",
                "Each round will draw a single card from the deck.",
                "The Goal of the game is to try to guess if the next card drawn is the",
                "",
                "SAME suit",
                "",
                "or",
                "",
                "DIFFERENT suit",
                "",
                "Once a choice is made, the second card is revealed.",
                "If the player guess correctly, they gain 1 point.",
                "Try to get as many points as possible.",
                ""
            };
        }

        public override void PlayGame()
        {
            base.PlayGame();

            bool running = true;
            
            string[] SameOrDifferent = { "Same", "Different" };

            int round = 1;
            
            
            while(running)
            {
                Card firstCard = decks[1].cards[0];
                Card secondCard = decks[(int)deckPile.main].cards[1];


                int result = 0;

                string[] prompts =
                {
                    "--------------------------------------------------------------------",//0
                    $"Round {round}/13                Score: {points[((int)pointSystem.playerPoints)].points}",//1
                    "--------------------------------------------------------------------",//2
                    "",//3
                    "A card is drawn...",//4
                    "",//5
                    firstCard.Info(),//6
                    "",//7
                    "Will the suit be the same, or different?"//8
                };

                ConsoleColor[] promptColors =
                {
                    ConsoleColor.Green,//0
                    ConsoleColor.Green,//1
                    ConsoleColor.Green,//2
                    ConsoleColor.Magenta,//3
                    ConsoleColor.Magenta,//4
                    ConsoleColor.Magenta,//5
                    ConsoleColor.Red,//6
                    ConsoleColor.Red,//7
                    ConsoleColor.Green//8
                };




                int selectedChoice = MenuPrompt(prompts, promptColors, SameOrDifferent);
                selectedChoice -=1;

                Console.WriteLine();
                CenterString("The Next card is...", ConsoleColor.Magenta);
                Console.WriteLine();
                CenterString($"{secondCard.Info()}",ConsoleColor.Red);
                Console.WriteLine();

                //Check to see if cards are the same or different
                if (firstCard.suit == secondCard.suit) result = 0; //Same
                else result = 1; //Different


                if (result == selectedChoice)
                {
                    CenterString("You have guessed Correctly!",ConsoleColor.Green);
                    CenterString("+1 Point", ConsoleColor.Green);
                    Console.WriteLine();
                    points[(int)pointSystem.playerPoints].AddPoints(1);
                }
                else
                {
                    CenterString("You have guessed INCORRECTLY!", ConsoleColor.Red);
                }

                Continue();

                decks[(int)deckPile.main].DiscardCard(decks[(int)deckPile.discard], 2, 0);

                round++;

                if (decks[((int)deckPile.main)].cards.Count <= 0)
                {
                    running = false;
                }
            }

            EndGame();
        }



        void EndGame()
        {
            Console.WriteLine("\n\n");

            CenterString($"All cards have been played...", ConsoleColor.Green);
            Console.WriteLine();
            CenterString($"Score = {points[((int)pointSystem.playerPoints)].points}");

            Continue();
        }
    }
}
