using System;

namespace SolitaireModel
{
    public class PlayingCard : IPlayingCard, IEquatable<PlayingCard>
    {
        public PlayingCard(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;

            if (Suit == Suit.Clubs || Suit == Suit.Spades)
            {
                Color = CardColor.Black;
            }
            else
            {
                Color = CardColor.Red;
            }
        }

        public bool Equals(PlayingCard other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Rank == other.Rank && Suit == other.Suit;
        }

        public Rank Rank { get; }

        public Suit Suit { get; }

        public override string ToString()
        {
            return "[" + Suit + ";" + Rank + "]";
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

        public CardColor Color { get; }
    }
}