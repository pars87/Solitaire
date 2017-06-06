using System;

namespace SolitaireModel
{
    public class PlayingCard : IPlayingCard, IEquatable<PlayingCard>
    {
        public PlayingCard(Suits suit, Ranks rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public Ranks Rank { get; }

        public Suits Suit { get; }

        public bool Equals(PlayingCard other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Rank == other.Rank && Suit == other.Suit;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PlayingCard)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)Rank * 397) ^ (int)Suit;
            }
        }

        public static bool operator ==(PlayingCard left, PlayingCard right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PlayingCard left, PlayingCard right)
        {
            return !Equals(left, right);
        }
    }
}