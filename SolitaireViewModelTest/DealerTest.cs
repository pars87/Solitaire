using Microsoft.VisualStudio.TestTools.UnitTesting;

using SolitaireModel;

using SolitaireViewModel;

namespace SolitaireViewModelTest
{
    [TestClass]
    public class DealerTest
    {
        // TODO [REAY]: missing test
        [TestMethod]
        public void CreatDealer_ShuffleCard_VerifyShuffle()
        {
            // Arrange
            CardDeck cardDeck = new CardDeck();
            var dealer = new SolitaireDealer(cardDeck);

            // Act
            dealer.Shuffle();

            // Assert
        }

        [TestMethod]
        public void CreatDealer_DealACard_VerifyCardDeckSize()
        {
            // Arrange
            CardDeck cardDeck = new CardDeck();
            var dealer = new SolitaireDealer(cardDeck);

            // Act
            dealer.DealACard();

            // Assert
            Assert.AreEqual(51, cardDeck.Cards.Count);
        }

        [TestMethod]
        public void CreatDealer_DealACard_VerifyCardIsNotNull()
        {
            // Arrange
            var cardDeck = new CardDeck();
            var dealer = new SolitaireDealer(cardDeck);

            // Act
            var card = dealer.DealACard();

            // Assert
            Assert.IsNotNull(card);
        }
    }
}