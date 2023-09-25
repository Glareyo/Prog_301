using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using static P1_GameFramework.UIUtility;

namespace P1_GameFramework.Games
{
    internal class HigherOrLower : Game
    {
        const int DISCARD = 0;
        const int MAIN = 1;

        const int SCORE = 0;

        const int LOWER = 0;
        const int HIGHER = 1;
        public HigherOrLower(string _title) : base(_title)
        {
            decks.Add(new Deck("Discard", 0, 0));
            decks.Add(new Deck("Main", 4, 13));
            points.Add(new PointSystem("Score", 0));

            instructions = new string[]
            {
                "The Game plays 26 Rounds.",
                "Each round will draw a single card from the deck.",
                "The Goal of the game is to try to guess if the next card drawn is",
                "",
                "a HIGHER number",
                "",
                "or",
                "",
                "a LOWER number",
                "",
                "Once a choice is made, the second card is revealed.",
                "If the player guess correctly, they gain 1 point.",
                "Try to get as many points as possible.",
                "",
                "Note: Ace = 1, Jacks = 11, Queens = 12, Kings = 13",
                ""
            };
        }

        public override void PlayGame()
        {
            base.PlayGame();

            bool running = true;

            string[] HigherOrLowerOptions = { "Lower", "Higher" };

            int round = 1;


            while (running)
            {
                Card firstCard = decks[1].cards[0];
                Card secondCard = decks[MAIN].cards[1];


                int result = 0;

                string[] prompts =
                {
                    "--------------------------------------------------------------------",//0
                    $"Round {round}/26                Score: {points[SCORE].points}",//1
                    "--------------------------------------------------------------------",//2
                    "",//3
                    "A card is drawn...",//4
                    "",//5
                    isAFaceCard(firstCard),//6
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




                int selectedChoice = MenuPrompt(prompts, promptColors, HigherOrLowerOptions);
                selectedChoice -= 1;

                Console.WriteLine();
                CenterString("The Next card is...", ConsoleColor.Magenta);
                Console.WriteLine();

                string temp = secondCard.Info();
                CenterString($"{isAFaceCard(secondCard)}", ConsoleColor.Red);
                Console.WriteLine();

                //Check to see if first card is higher or lower
                if (firstCard.value >= secondCard.value) result = LOWER; //Same
                else result = HIGHER; //Different


                if (result == selectedChoice)
                {
                    CenterString("You have guessed Correctly!", ConsoleColor.Green);
                    CenterString("+1 Point", ConsoleColor.Green);
                    Console.WriteLine();
                    points[SCORE].AddPoints(1);
                }
                else
                {
                    CenterString("You have guessed INCORRECTLY!", ConsoleColor.Red);
                }

                Continue();

                decks[MAIN].DiscardCard(decks[DISCARD], 2, 0);

                round++;

                if (decks[MAIN].cards.Count <= 0)
                {
                    running = false;
                }
            }

            EndGame();
        }


        string isAFaceCard(Card card)
        {
            if (card.value > 10 || card.value == 1)
                return $"{card.Info()}, Value: {card.value}.";


            else
                return card.Info();
        }

        void EndGame()
        {
            Console.WriteLine("\n\n");

            CenterString($"All cards have been played...", ConsoleColor.Green);
            Console.WriteLine();
            CenterString($"Score = {points[SCORE].points}");

            Continue();
        }
    }
}
