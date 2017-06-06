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
            Cards = new List<Card>();

            // Initialize the deck
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                if (suit == Suits.None)
                {
                    continue;
                }

                foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
                    if (rank == Ranks.Joker)
                    {
                        continue;
                    }

                    Cards.Add(new Card(suit, rank));
                }
            }

            // Add Joker
            AddJoker(nrOfJoke);
        }

        public List<Card> Cards { get; }

        private void AddJoker(uint nrOfJoke)
        {
            if (nrOfJoke < 1)
            {
                return;
            }

            if (Cards == null)
            {
                throw new NullReferenceException("Card in not initilized");
            }

            for (int i = 0; i < nrOfJoke; i++)
            {
                Cards.Add(new Card(Suits.None, Ranks.Joker));
            }
        }
    }
}