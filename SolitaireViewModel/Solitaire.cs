using SolitaireModel;

namespace SolitaireViewModel
{
    public class Solitaire : IGame
    {
        public Solitaire(ISolitaireDealer dealer, ISolitaireBoard board, ICardDeck cardDeck)
        {
            Dealer = dealer;
            Board = board;
            CardDeck = cardDeck;
            player = new Player();
        }


        // bool IsMoveToFoundationValid(ICard FromCard, ICard toCard);
        public ISolitaireDealer Dealer { get; private set; }
        public IPlayer player { get; private set; }

        public ISolitaireBoard Board { get; private set; }

        public ICardDeck CardDeck { get; private set; }
    }
}