namespace SolitaireModel
{
    public class JokerCard : ICard
    {
        public override string ToString()
        {
            return "Joker";
        }

        public CardColor Color { get; }
    }
}