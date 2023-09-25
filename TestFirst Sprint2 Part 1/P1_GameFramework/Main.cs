using P1_GameFramework.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static P1_GameFramework.UIUtility;

namespace P1_GameFramework
{
    public class Main
    {
        // All the available games.
        private List<Game> games;


        

        // Starts up the menu for selecting a game.
        public void MainMenu()
        {
            
            bool running = true;
            
            

            while(running)
            {
                string[] titlePrompts =
                {
                    "+------------+",
                    "| Card Games |",
                    "+------------+",
                    "",
                    $"Welcome, {playerName}!",
                    $"Please Select an option below:",
                };
                string[] options =
                {
                    "Play a Game",
                    "Change Name",
                    "Credits",
                    "Exit"
                };
                switch (MenuPrompt(titlePrompts,options))
                {
                    case 1:
                        SelectGame();
                        break;
                    case 2:
                        GetPlayerName();
                        break;
                    case 3:
                        Credits();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }

        }

        // Has the player type a name and sets it to the player.
        private void GetPlayerName()
        {
            CenterString("What would you like to be named?", ConsoleColor.Green);
            CenterString("-------------------------------");
            Notify("Press \'Enter\' to confirm");
            playerName = GetInput();
            Continue();
        }

        private void Credits()
        {
            Console.Clear();
            CenterString("Game by Nehemiah Cedillo", ConsoleColor.Cyan);
            CenterString("Creation Date: Spring 2023");
            CenterString("For Programming 201 at Columbia Chicago College");
            Console.WriteLine();

            CenterString("Credits",ConsoleColor.Green);
            CenterString("Symbl Website", ConsoleColor.Yellow);
            CenterString("Provided different Unicode Symbols that can be seen on the cards in Highest Match", ConsoleColor.White);
            CenterString("https://symbl.cc/en/", ConsoleColor.Cyan);
            
            Console.WriteLine();
            
            CenterString("\"How to print Unicode text on console window using C#\" by ProgrammerTube, YouTube", ConsoleColor.Yellow);
            CenterString("Showed, via YouTube, how to apply unicode to appear in a console application.",ConsoleColor.White);
            CenterString("https://www.youtube.com/watch?v=rTqBnJ8HrSc", ConsoleColor.Cyan);
            
            Console.WriteLine();

            CenterString("Janell Baxter", ConsoleColor.Yellow);
            CenterString("Professor of Programming 201 at Columbia Chicago College.", ConsoleColor.White);
            CenterString("SP23-PROG 201-02, Spring 2023.", ConsoleColor.White);
            CenterString("Provided content and materials of learning C#", ConsoleColor.White);

            Console.WriteLine(); 

            CenterString("Playtesters: Max Bertland and Meghan",ConsoleColor.Yellow);
            CenterString("Provided playtesting and notes on earlier prototypes of the card Games", ConsoleColor.White);

            Console.WriteLine();
            Continue();
        }

        // Selects a game to startup.
        private void SelectGame()
        {
            Game game;
            string[] prompts =
            {
                "+-------+",
                "| Games |",
                "+-------+",
                "",
                "Please Select a Game:"
            };
            string[] gameOpt =
            {
                "Apples or Oranges",
                "Higher or Lower",
                "Highest Match",
                "<-- Back"
            };
            bool running = true;

            while(running)
            {
                switch(MenuPrompt(prompts,gameOpt))
                {
                    case 1:
                        game = new ApplesOrOranges("Apple or Oranges");
                        game.StartupGame();
                        break;
                    case 2:
                        game = new HigherOrLower("Higher or Lower");
                        game.StartupGame();
                        break;
                    case 3:
                        game = new HighestMatch("Highest Match");
                        game.StartupGame();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
    }
}