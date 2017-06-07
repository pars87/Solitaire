using System;
using System.Collections.Generic;

using SolitaireModel;

namespace SolitaireViewModel
{
    public class SolitaireBoard : Board, ISolitaireBoard
    {
        public SolitaireBoard()
        {
            InitFoundations();
            InitPiles();
        }

        public Stack<IPlayingCard>[] Foundations { get; private set; }

        public Stack<IPlayingCard>[] Piles { get; private set; }

        public Stack<IPlayingCard> VierwCards { get; }

        private void InitPiles()
        {
            Piles = new Stack<IPlayingCard>[7];
            for (var i = 0; i < Piles.Length; i++)
            {
                Piles[i] = new Stack<IPlayingCard>();
            }
        }

        public void InitFoundations()
        {
            Foundations = new Stack<IPlayingCard>[4];
            for (var i = 0; i < Foundations.Length; i++)
            {
                Foundations[i] = new Stack<IPlayingCard>();
            }
        }

        public bool IsAddingToFoundationLegal(IPlayingCard card, int foundationNr)
        {
            if (card == null)
            {
                throw new ArgumentNullException("Card must NOT be NULL.");
            }

            if (foundationNr < 0 || foundationNr > 3)
            {
                throw new ArgumentOutOfRangeException("Foundation number: " + foundationNr + " is out of range.");
            }

            var foundation = Foundations[foundationNr];
            if (foundation == null)
            {
                throw new NullReferenceException("Foundation : " + foundationNr + " is Null.");
            }

            if (foundation.Count == 0)
            {
                return card.Rank == Rank.Ace;
            }

            var topCard = foundation.Peek();
            if (topCard.Suit == card.Suit)
            {
                if (card.Rank == topCard.Rank + 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsAddingToPileLegal(IPlayingCard card, int pileNr)
        {
            if (pileNr < 0 || pileNr > 6)
            {
                throw new ArgumentOutOfRangeException("Foundation number: " + pileNr + " is out of range.");
            }

            if (card == null)
            {
                throw new ArgumentNullException("Card must NOT be NULL.");
            }

            var pile = Piles[pileNr];
            if (pile == null)
            {
                throw new NullReferenceException("Pile : " + pileNr + " is Null.");
            }

            if (Piles[pileNr].Count == 0)
            {
                return card.Rank == Rank.King;
            }

            var topPileCard = Piles[pileNr].Peek();
            if (IsOpposite(topPileCard, card))
            {
                if (card.Rank == topPileCard.Rank + 1)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsOpposite(IPlayingCard cardA, IPlayingCard cardB)
        {
            return cardA.Color != cardB.Color;
        }
    }
}