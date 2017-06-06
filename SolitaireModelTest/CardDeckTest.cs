using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SolitaireModel;

namespace SolitaireModelTest
{
    [TestClass]
    public class CardDeckTest
    {
        [TestMethod]
        public void CreatDeckOfCard_VerifySize()
        {
            // Arrange and Act
            ICardDeck cardDeck = new CardDeck();
            
            // Assert
           Assert.AreEqual(52, cardDeck.Cards.Count);
        }

        [TestMethod]
        public void CreatDeckOfCardWithJoker_VerifySize()
        {
            // Arrange and Act
            ICardDeck cardDeck = new CardDeck(2);

            // Assert
            Assert.AreEqual(54, cardDeck.Cards.Count);
        }
    }
}
