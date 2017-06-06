using System;

using SolitaireModel;

namespace SolitaireViewModel
{
    public class GameManager : IGameManager
    {
        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void End()
        {
            SelectedGame = null;
        }

        public void Restart()
        {
            throw new System.NotImplementedException();
        }

        public IGame SelectedGame { get; private set; }

        public void SelectGame(Game game)
        {
            switch (game)
            {
                case Game.Solitaire:
                    var cardDeck = new CardDeck();
                    var dealer = new SolitaireDealer(cardDeck);
                    var board = new SolitaireBoard();
                    SelectedGame = new Solitaire(dealer, board, cardDeck);

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(game), game, null);
            }
        }
    }
}