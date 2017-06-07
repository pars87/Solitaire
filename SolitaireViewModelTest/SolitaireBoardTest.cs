using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using SolitaireModel;

using SolitaireViewModel;

namespace SolitaireViewModelTest
{
    [TestClass]
    public class SolitaireBoardTest
    {
        [TestMethod]
        public void CreatBoard_MoveCardToLligalePile_False()
        {
            // Arrange
            var board = new SolitaireBoard();
            board.Piles[3].Push(new PlayingCard(Suit.Clubs, Rank.King));
            board.Piles[3].Push(new PlayingCard(Suit. Diamonds, Rank.Five));
            board.Piles[3].Push(new PlayingCard(Suit.Hearts, Rank.Eight));

            var playerCard = new PlayingCard(Suit.Clubs, Rank.Nine);

            // Act
            var actual = board.IsAddingToPileLegal(playerCard, 3);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void MoveRank9CardToPile_PileIsEmpty_False()
        {
            // Arrange
            var board = new SolitaireBoard();

            var playerCard = new PlayingCard(Suit.Clubs, Rank.Nine);

            // Act
            var actual = board.IsAddingToPileLegal(playerCard, 3);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void MoveRankKingCardToPile_PileIsEmpty_True()
        {
            // Arrange
            var board = new SolitaireBoard();

            var playerCard = new PlayingCard(Suit.Clubs, Rank.King);

            // Act
            var actual = board.IsAddingToPileLegal(playerCard, 3);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The pile is out of the range")]
        public void MoveCardToPileOutOfRange_ExpectOutOfRangeException()
        {
            // Arrange
            var board = new SolitaireBoard();

            var playerCard = new PlayingCard(Suit.Clubs, Rank.King);

            // Act and Assert
            board.IsAddingToPileLegal(playerCard, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Card must NOT be NULL.")]
        public void MoveNullCardToPile_ExpectOutOfRangeException()
        {
            // Arrange
            var board = new SolitaireBoard();
            board.Piles[3].Push(new PlayingCard(Suit.Clubs, Rank.King));

            // Act and Assert
            board.IsAddingToPileLegal(null, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The foundation is out of the range")]
        public void MoveCardTofoundationOutOfRange_ExpectOutOfRangeException()
        {
            // Arrange
            var board = new SolitaireBoard();

            var playerCard = new PlayingCard(Suit.Clubs, Rank.King);

            // Act and Assert
            board.IsAddingToFoundationLegal(playerCard, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Card must NOT be NULL.")]
        public void MoveNullCardToFoundation_ExpectOutOfRangeException()
        {
            // Arrange
            var board = new SolitaireBoard();

            // Act and Assert
            board.IsAddingToFoundationLegal(null, 3);
        }

        [TestMethod]
        public void MoveAceCardToFoundation_FoundationIsEmpty_True()
        {
            // Arrange
            var board = new SolitaireBoard();

            var playerCard = new PlayingCard(Suit.Clubs, Rank.Ace);

            // Act
            var actual = board.IsAddingToFoundationLegal(playerCard, 3);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void MoveKingSpadeCardToFoundation_FoundationContainQueenSpade_True()
        {
            // Arrange
            var board = new SolitaireBoard();
            board.Foundations[3].Push(new PlayingCard(Suit.Spades, Rank.Queen));


            var playerCard = new PlayingCard(Suit.Spades, Rank.King);

            // Act
            var actual = board.IsAddingToFoundationLegal(playerCard, 3);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void MoveIlligalCardToFoundation_FoundationIsEmpty_false()
        {
            // Arrange
            var board = new SolitaireBoard();

            var playerCard = new PlayingCard(Suit.Clubs, Rank.Ace);

            // Act
            var actual = board.IsAddingToFoundationLegal(playerCard, 3);

            // Assert
            Assert.AreEqual(true, actual);
        }
    }
}