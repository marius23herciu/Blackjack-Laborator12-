using Blackjack_Laborator12_.DeckOfCards;
using Blackjack_Laborator12_.Games;
using System;

namespace Blackjack_Laborator12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.ShuffleDeck();

            Player john = new Player("John");
            Player robert = new Player("Robert");
            Player andrew = new Player("Andrew");

            Blackjack blackjack = new Blackjack();
            blackjack.AddPlayer(john);
            blackjack.AddPlayer(robert);
            blackjack.AddPlayer(andrew);

            john.DrawCard(deck);
            john.DrawCard(deck);

            robert.DrawCard(deck);
            robert.DrawCard(deck);
            robert.DrawCard(deck);

            andrew.DrawCard(deck);
            andrew.DrawCard(deck);
            andrew.DrawCard(deck);

            foreach (var player in blackjack.listOfPlayers)
            {
                Console.WriteLine(player);
            }

            deck.FillDeck();
            deck.ShuffleDeck();

            Console.WriteLine($"Id of winner is:  {blackjack.Evaluate()}");
        }
    }
}
