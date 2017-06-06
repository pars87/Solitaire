using System;
using System.Collections.Generic;

namespace SolitaireModel
{
    /// <summary>
    /// The card deck.
    /// </summary>
    public class CardDeck : ICardDeck
    {
        public CardDeck(uint nrOfJoke = 0)
        {
            Cards = new List<ICard>();

            // Initialize the deck
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new PlayingCard(suit, rank));
                }
            }

            // Add Joker
            AddJoker(nrOfJoke);
        }

        public List<ICard> Cards { get; }

        private void AddJoker(uint nrOfJoke)
        {
            if (nrOfJoke < 1)
            {
                return;
            }

            if (Cards == null)
            {
                throw new NullReferenceException("Card deck in not initilized.");
            }

            for (int i = 0; i < nrOfJoke; i++)
            {
                Cards.Add(new JokerCard());
            }
        }
    }
}