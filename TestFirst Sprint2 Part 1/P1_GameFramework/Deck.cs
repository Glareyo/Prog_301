using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static P1_GameFramework.UIUtility;

namespace P1_GameFramework
{
    public class Deck
    {
        private string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };


        public List<Card> cards; // The number of cards the deck has.
        public string name; // Name of the deck
        public int deckSize; // Size of the deck.

        /// <summary>
        ///Used for unit testing.
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="UnitTesting"></param>
        public Deck(string _name, bool UnitTesting)
        {
            name = _name;
            cards = new List<Card>();

            deckSize = 52;
        }



        public Deck(string _name)
        {
            //Assign the name
            //Create a new list of cards
            //Deck size = 52
            //CreateCards()
        }
        public Deck(string _name,int numSuits, int numCardsPerSuit)
        {
            //Assign the name
            //Create a new list of cards
            //Deck size = number of possible cards based on suit amounts and card amounts per suit
            //CreateCards()

            //CreateCards that utilize the limited numbers
        }
        // Shuffle the deck of cards via randomization.
        public void Shuffle()
        {
            //Utilizing Method #2: Fisher-Yates Shuffle
            //From Programming 201 at Columbia Chicago College
            //Spring 2023 - SP23-PROG 201-02


            //Shuffle the entire deck
        }

        /// Reveal a card from the deck, but do not remove.
        /// <param name="cardPosition">Which card to reveal.</param>
        public string RevealCard(int cardPosition)
        {
            //Target a specific card based on the card position

            //return $"{cardRank} of {cardSuit}";
            return "";
        }

        /// <summary>
        /// Discard a card from this deck to a target deck.
        /// </summary>
        /// <param name="targetDeck">The target deck to discard a card to.</param>
        /// <param name="numOfCards">How many cards to discard.</param>
        /// <param name="cardPosition">Which card position in particular to discard.</param>
        public void DiscardCard(Deck targetDeck, int numOfCards, int cardPosition)
        {
            //Target a specific card from the deck, then add it to the other deck
        }

        /// Creates the cards needed for the deck.
        public void CreateCards()
        {
            //Create all possible card options from the entire array.
        }
        public void CreateCards(int numOfSuits, int numOfCardsPerSuit)
        {
            //Create cards based on the suit and number of cards per array.
        }

        //Gets the name of the deck.
        public string GetName
        {
            //Return the name of the deck
            get { return ""; }
        }





        //Temporary method for checking
        //No unit testing required for this.
        public void RevealAllCards()
        {
            CenterString($"The \"{name}\" has...");
            foreach(Card card in cards)
            {
                CenterString($"{card.rank} of {card.suit}");
            }
        }
    }
}