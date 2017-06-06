using SolitaireModel;

namespace SolitaireViewModel
{
    public interface IDealer
    {
        ICard DealACard();

        void Shuffle();

        void Deal();
    }
}