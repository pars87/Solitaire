using System.Collections.Generic;

namespace SolitaireModel
{
    public interface ICardDeck
    {
        List<ICard> Cards { get; }
    }
}