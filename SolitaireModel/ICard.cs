namespace SolitaireModel
{
    interface ICard
    {
        Ranks Rank { get; }

        Suits Suit { get; }
    }
}