using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SolitaireModel;

namespace SolitaireModelTest
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CreatePlayingCard_VerifyColor()
        {
            // Arrange, Act and Assert
            Assert.AreEqual(CardColor.Black, new PlayingCard(Suit.Spades, Rank.Ace).Color);
            Assert.AreEqual(CardColor.Black, new PlayingCard(Suit.Clubs, Rank.Ace).Color);
            Assert.AreEqual(CardColor.Red, new PlayingCard(Suit.Diamonds, Rank.Ace).Color);
            Assert.AreEqual(CardColor.Red, new PlayingCard(Suit.Hearts, Rank.Ace).Color);
        }
    }
}
