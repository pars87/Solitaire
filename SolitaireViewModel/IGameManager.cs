using SolitaireModel;

namespace SolitaireViewModel
{
    public interface IGameManager
    {
        IGame SelectedGame { get; }

        void SelectGame(Game game);

        void Start();

        void End();

        void Restart();
    }
}