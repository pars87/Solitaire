using System;

namespace SolitaireModel
{
    public class Card : ICard, IEquatable<Card>
    {
        public Card(Suits suit, Ranks rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public Ranks Rank { get; }

        public Suits Suit { get; }

        public bool Equals(Card other)
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
            return Equals((Card)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)Rank * 397) ^ (int)Suit;
            }
        }

        public static bool operator ==(Card left, Card right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Card left, Card right)
        {
            return !Equals(left, right);
        }
    }
}