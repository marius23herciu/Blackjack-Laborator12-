using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Laborator12_.DeckOfCards
{
    public class Card
    {
        public int value;
        public static string[] suits = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
        public string suit;
        /// <summary>
        /// Creates a card.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public Card(int value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{this.value} {this.suit}";
        }
    }
}
