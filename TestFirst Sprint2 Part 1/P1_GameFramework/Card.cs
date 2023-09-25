using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1_GameFramework
{
    public class Card
    {
        
        
        // Describes the specific rank of the card, 1-10, Jack, queen, king, or joker.
        public string rank;
        // The actual value of the card via number.
        public int value;
        // The symbol + Color of the card.
        public string suit;

        // Sets the target value of the card via the game setup.
        public string Info()
        {
            return $"{rank} of {suit}";
        }
    }
}