using SolitaireModel;

namespace SolitaireViewModel
{
    public abstract class Dealer : IDealer
    {
        private ICardDeck CardDeck { get; }

        public Dealer(ICardDeck cardDeck)
        {
            CardDeck = cardDeck;
            Shuffle();
        }

        public ICard DealACard()
        {
            var card = CardDeck.Cards[0];
            CardDeck.Cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            CardDeck.Cards.Shuffle();
        }

        public void Deal()
        {
            throw new System.NotImplementedException();
        }
    }
}
