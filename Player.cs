using Blackjack_Laborator12_.DeckOfCards;
using Blackjack_Laborator12_.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Laborator12_
{
    public class Player : IPlayer
    {
        public Guid Id { get; set; }
        public string name;
        public List<Card> listOfCards { get; set; }
        /// <summary>
        /// Creates player
        /// </summary>
        /// <param name="name"></param>
        public Player(string name)
        {
            this.Id = Guid.NewGuid();
            this.name = name;
            this.listOfCards = new List<Card>();
        }
        /// <summary>
        /// Draws random card from a deck and adds it to players hand.
        /// </summary>
        /// <param name="deck"></param>
        public void DrawCard(Deck deck)
        {
            listOfCards.Add(deck.ExtractCard());
        }
        /// <summary>
        /// Ads a card to players hand.
        /// </summary>
        /// <param name="card"></param>
        public void DrawCard(Card card)
        {
            listOfCards.Add(card);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Id + " ");
            sb.Append(this.name + " ");
            sb.Append("\n");
            foreach (var card in listOfCards)
            {
                sb.Append(card);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
