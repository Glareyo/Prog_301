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

        public Deck(string _name)
        {
            name = _name;
            cards = new List<Card>();

            deckSize = 52;

            CreateCards();
        }
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
        public Deck(string _name,int numSuits, int numCardsPerSuit)
        {
            name = _name;
            cards = new List<Card>();
            deckSize = numSuits * numCardsPerSuit;

            CreateCards(numSuits,numCardsPerSuit);
        }

        // Shuffle the deck of cards via randomization.
        public void Shuffle()
        {
            //Utilizing Method #2: Fisher-Yates Shuffle
            //From Programming 201 at Columbia Chicago College
            //Spring 2023 - SP23-PROG 201-02

            if (deckSize > 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int firstCard = rand.Next(deckSize - 1);
                    int secondCard = rand.Next(deckSize - 1);


                    //Swap cards
                    Card temp = cards[firstCard];
                    cards[firstCard] = cards[secondCard];
                    cards[secondCard] = temp;
                }
            }
        }

        /// Reveal a card from the deck, but do not remove.
        /// <param name="cardPosition">Which card to reveal.</param>
        public string RevealCard(int cardPosition)
        {
            string cardRank = cards[cardPosition].rank;
            string cardSuit = cards[cardPosition].suit;

            return $"{cardRank} of {cardSuit}";
        }

        /// <summary>
        /// Discard a card from this deck to a target deck.
        /// </summary>
        /// <param name="targetDeck">The target deck to discard a card to.</param>
        /// <param name="numOfCards">How many cards to discard.</param>
        /// <param name="cardPosition">Which card position in particular to discard.</param>
        public void DiscardCard(Deck targetDeck, int numOfCards, int cardPosition)
        {
            for(int i = 0; i < numOfCards; i++)
            {
                targetDeck.cards.Add(this.cards[cardPosition]);
                this.cards.RemoveAt(cardPosition);
            }
        }

        /// Creates the cards needed for the deck.
        public void CreateCards()
        {
            for (int i = 0; i < (deckSize / 4); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards.Add(new Card()
                    {
                        value = i,
                        suit = suits[j],
                        rank = ranks[i]
                    });

                }
            }
        }
        public void CreateCards(int numOfSuits, int numOfCardsPerSuit)
        {
            int total = 0;

            for (int i = 0; i < numOfCardsPerSuit; i++)
            {
                for (int j = 0; j < numOfSuits; j++)
                {
                    cards.Add(new Card()
                    {
                        value = i+1,
                        suit = suits[j],
                        rank = ranks[i]
                    });
                    total++;

                }
            }
        }

        //Gets the name of the deck.
        public string GetName
        {
            get { return this.name; }
        }

        //Temporary method for checking
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