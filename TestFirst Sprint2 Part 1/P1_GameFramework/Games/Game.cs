using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using static P1_GameFramework.UIUtility;

namespace P1_GameFramework
{
    public class Game
    {
        
        
        
        protected string title; // Set the title of the game.
        protected List<Deck> decks = new List<Deck>(); // A list of decks that the game will use. Could be 1 or more.  
        protected List<PointSystem> points = new List<PointSystem>(); // A list of point systems that the game may use for either win conditions or general point tracking.

        protected string[] instructions;


        public Game(string _title)
        {
            title = _title;
            decks = new List<Deck>();
            points = new List<PointSystem>();
        }
        /// Start the game. Every game will run through this upon selection
        public virtual void StartupGame()
        {
            bool running = true;
            string[] introOptions =
            {
                "Play Game",
                "How to Play",
                "Quit"
            };

            Console.Clear();

            
            while(running)
            {
                switch(MenuPrompt(title,introOptions))
                {
                    case 1:
                        PlayGame();
                        running = false;
                        break;
                    case 2:
                        DisplayRules();
                        break;
                    case 3:
                        running = false;
                        break;
                }
            }
        }

        public virtual void PlayGame()
        {
            foreach (Deck deck in decks)
            {
                deck.Shuffle();
            }
        }


        // Show the game rules before returning to playing the game.
        public virtual void DisplayRules()
        {
            //CenterString("Display Rules here...", ConsoleColor.Red);
            DynamicTitleBox($"How to play {title}");
            
            foreach(string s in instructions)
            {
                CenterString(s, ConsoleColor.Green);
            }
            
            Continue();
        }

        /// <summary>
        /// This will add a certain amount of points to a target pool of points.
        /// </summary>
        /// <param name="targetPoints">Which point set will be recieving the points.</param>
        /// <param name="numberOfPoints">How many points will be given.</param>
        private void AddPoint(ref int targetPoints, int numberOfPoints)
        {
            throw new System.NotImplementedException();
        }

        private void DynamicTitleBox(string title)
        {
            string fullTitle = $"| {title} |";
            string Border = "+";

            for (int i = 0; i < fullTitle.Length; i++)
                Border += "-";
            Border += "+";

            CenterString(Border, ConsoleColor.Green);
            CenterString(title, ConsoleColor.Green);
            CenterString(Border, ConsoleColor.Green);
        }

        
    }
}