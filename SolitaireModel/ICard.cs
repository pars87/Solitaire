namespace SolitaireModel
{
    interface IPlayingCard : ICard
    {
        Ranks Rank { get; }

        Suits Suit { get; }
    }

    public interface ICard {}
}