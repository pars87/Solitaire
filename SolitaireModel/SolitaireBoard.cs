using System;
using System.Collections.Generic;
using System.Linq;

using SolitaireModel;

namespace SolitaireViewModel
{
    public class SolitaireBoard : Board, ISolitaireBoard
    {
        public SolitaireBoard()
        {
            Foundations = new Stack<IPlayingCard>[4];
            Piles = new Stack<IPlayingCard>[7];
        }

        void AddToPile(IPlayingCard card, int pileNr)
        {
            
        }

        bool IsAddingToPileLegal(IPlayingCard card, int pileNr)
        {
            return false;

        }

        private bool IsOpposite(IPlayingCard cardA, IPlayingCard cardB)
        {
            return cardA.Color != cardB.Color;
        }

        public Stack<IPlayingCard>[] Foundations { get; }

        public Stack<IPlayingCard>[] Piles { get; }

        public Stack<IPlayingCard> VierwCards { get; }
    }
}