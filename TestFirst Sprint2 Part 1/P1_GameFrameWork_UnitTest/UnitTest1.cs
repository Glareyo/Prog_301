using P1_GameFramework;

namespace P1_GameFrameWork_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Deck_CreatedDeck()
        {
            Deck d = CreateDeck();

            d.CreateCards();

            Assert.IsTrue(d.cards.Count == d.deckSize);
        }
        [TestMethod]
        public void Deck_CreatedLimitedDeck()
        {
            Deck deck = CreateDeck();
            deck.CreateCards(2, 10);

            Assert.IsTrue(deck.cards.Count == 20);
        }
        [TestMethod]
        public void Deck_CreatedLimitedDeck_Instatiating()
        {
            Deck deck = new Deck("Deck", 2, 10);

            Assert.IsTrue(deck.cards.Count == 20);
        }
        [TestMethod]
        public void Deck_IsShuffled()
        {
            Deck one = CreateDeck();
            Deck two = CreateDeck();

            one.CreateCards();
            two.CreateCards();

            one.Shuffle();

            bool allTheSame = true;
            for (int i = 0; i < one.cards.Count; i++)
                if (one.cards[i] != two.cards[i]) allTheSame = false;

            Assert.IsFalse(allTheSame);
        }
        [TestMethod]
        public void Deck_RevealIsCorrect()
        {
            Deck d = CreateDeck();

            d.CreateCards();
            //First card should be ace of diamonds.

            string revealedString = d.RevealCard(0);

            Assert.IsTrue(revealedString == "Ace of Diamonds");

            revealedString = d.RevealCard(d.cards.Count - 1);
            Assert.IsTrue(revealedString == "King of Hearts");
        }
        [TestMethod]
        public void Deck_DiscardingCardToAnotherDeck()
        {
            Deck one = CreateDeck();
            Deck two = CreateDeck();
            one.CreateCards();
            two.CreateCards();

            int cardCount = one.cards.Count;

            one.DiscardCard(two, 1, 0);

            Assert.IsTrue(one.cards.Count == cardCount - 1);
            Assert.IsTrue(two.cards.Count == cardCount + 1);
        }
        [TestMethod]
        public void Deck_GettingTheName()
        {
            string name = "Deck One";
            Deck d = new Deck(name);

            Assert.IsTrue(d.GetName == name);
        }

        Deck CreateDeck()
        {
            Deck d = new Deck("d", true);
            return d;
        }
    }
}
