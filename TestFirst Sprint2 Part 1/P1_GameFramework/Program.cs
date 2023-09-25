using P1_GameFramework.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static P1_GameFramework.UIUtility;


namespace P1_GameFramework
{
    internal class Program
    {
        /*
            * Card Games
            * Nehemiah Cedillo, 2/28/2023
            * Credits
            * - Provided different Unicode Symbols that can be seen on the cards in Highest Match by Symbl Website
            * - Showed, via YouTube, how to apply unicode to appear in a console application, How to print Unicode text on console window using C# by ProgrammerTube, YouTube.
            * - Content and Teachings of C# programming by Janell Baxter
            * - Playtested by Max Bertland and Meghan
        */


        static void Main(string[] args)
        {
            Main gameEngine = new Main();
            gameEngine.MainMenu();
            
        }
    }
}
