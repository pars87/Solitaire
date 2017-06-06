using System.Collections.Generic;

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

        public Stack<IPlayingCard>[] Foundations { get; }

        public Stack<IPlayingCard>[] Piles { get; }

        public Stack<IPlayingCard> VierwCards { get; }
    }
}