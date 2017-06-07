namespace SolitaireViewModel
{
    public interface IPlayer
    {
        int Score { get; set; }

        void TakeACard();
    }
}