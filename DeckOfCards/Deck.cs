using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack_Laborator12_.DeckOfCards
{
    public class Deck
    {
        public List<Card> deck = new List<Card>();
        public Deck()
        {
            this.deck = FillDeck();
        }
        /// <summary>
        /// Creates a full deck of cards.
        /// </summary>
        public List<Card> FillDeck()
        {
            int index = 0;
            if (deck.Count > 0)
            {
                deck.RemoveRange(0, deck.Count);
            }
            foreach (string suit in Card.suits)
            {
                for (int value = 2; value <= 14; value++)
                {
                    Card card = new Card(value, suit);
                    deck.Add(card);
                    index++;
                }
            }
            return deck;
        }
        /// <summary>
        /// Shuffles the cards existent in a deck.
        /// </summary>
        public void ShuffleDeck()
        {
            List<Card> shuffledDeck = new List<Card>();
            while (this.deck.Count>0)
            {
                var random = new Random();
                int index = random.Next(deck.Count);
                shuffledDeck.Add(this.deck[index]);
                deck.RemoveAt(index);
            }
            this.deck = shuffledDeck;
        }
        /// <summary>
        /// Extracts a random card from a deck and returns it.
        /// </summary>
        /// <returns></returns>
        public Card ExtractCard()
        {
            var random = new Random();
            int index = random.Next(deck.Count);
            Card extractedCard = deck[index];
            deck.RemoveAt(index);
            return extractedCard;
        }
    }
}
