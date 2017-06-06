using System.Collections.Generic;

namespace SolitaireModel
{
    public interface ICardDeck
    {
        List<Card> Cards { get; }
    }
}