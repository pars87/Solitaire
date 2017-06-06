using System.Collections.Generic;

using SolitaireModel;

namespace SolitaireViewModel
{
    public interface ISolitaireBoard : IBoard
    {
        Stack<IPlayingCard>[] Foundations { get; }

        Stack<IPlayingCard>[] Piles { get; }

        Stack<IPlayingCard> VierwCards { get; }
    }
}