namespace SolitaireModel
{
    public interface IPlayingCard : ICard
    {
        Rank Rank { get; }

        Suit Suit { get; }
    }

    public interface ICard
    {
        CardColor Color { get; }
    }
}