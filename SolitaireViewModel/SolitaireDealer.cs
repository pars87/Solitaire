using SolitaireModel;

namespace SolitaireViewModel
{
    public class SolitaireDealer : Dealer, ISolitaireDealer
    {
        public SolitaireDealer(ICardDeck cardDeck)
            : base(cardDeck)
        {
            
        }
    }
}