using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1_GameFramework
{
    public class Player
    {


        public Player(string _name)
        {
            name = _name;
            hand = new List<Card>();
            maxNumOfCards = 52;
        }
        /// <summary>
        /// The name of the player.
        /// </summary>
        private string name;
        /// <summary>
        /// The hand of cards the player has.
        /// </summary>
        private List<Card> hand;
        /// <summary>
        /// The max number of cards the player can have on hand, set by each game.
        /// </summary>
        private int maxNumOfCards;

        /// <summary>
        /// Set the max number of cards.
        /// </summary>
        public int MaxCards
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Allows the player to draw a card from a deck. Adds it to the player's hand.
        /// </summary>
        /// <param name="targetDeck">Which deck the player will draw from.</param>
        /// <param name="numOfCards">How many cards the player draws.</param>
        /// <param name="cardPosition">Where precisely to draw the card from the deck.</param>
        public void DrawCard(Deck targetDeck, int numOfCards, int cardPosition)
        {
            for (int i = 0; i < numOfCards; i++)
            {
                Card targetCard = targetDeck.cards[cardPosition + i];
                targetDeck.cards.Remove(targetCard);
                this.hand.Add(targetCard);
            }
        }

        //Shows the player's current hand on screen.
        public List<Card> GetHand
        {
            get { return hand; }
        }

        /// <summary>
        /// Allows the player to remove a card from their hand and place it in a target deck.
        /// </summary>
        /// <param name="targetDeck">Which deck the player discards the card.</param>
        /// <param name="numOfCards">How many cards the player discards.</param>
        /// <param name="cardPosition">Which precise card to discard.</param>
        public void DiscardCard(Deck targetDeck, int numOfCards, int cardPosition)
        {
            for (int i = 0; i < numOfCards; i++)
            {
                Card targetCard = this.hand[cardPosition];
                targetDeck.cards.Add(targetCard);
                this.hand.Remove(targetCard);
                cardPosition++;
            }
        }
        public void DiscardCard(Deck targetDeck, Card targetCard)
        {
            targetDeck.cards.Add(targetCard);
            this.hand.Remove(targetCard);
        }
        public void SwapACard(Deck targetDiscardDeck, Deck targetDrawDeck, int cardPosition)
        {//More specifically for Highest Match game
            Card targetCard = this.hand[cardPosition];
            targetDiscardDeck.cards.Add(targetCard);
            
            Card drawnCard = targetDrawDeck.cards[0];
            this.hand[cardPosition] = drawnCard;

            targetDrawDeck.cards.Remove(drawnCard);
        }
    }
}