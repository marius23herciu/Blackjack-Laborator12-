using Blackjack_Laborator12_.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Laborator12_.Games
{
    public class Blackjack : IBlackjack
    {

        public List<IPlayer> listOfPlayers { get; set; }
        public Blackjack()
        {
            this.listOfPlayers = new List<IPlayer>();
        }
        /// <summary>
        /// Checks the winner of a blackjack game and returns its ID.
        /// </summary>
        /// <returns></returns>
        public string Evaluate()
        {
            int winnerValue = 0;
            int indexOfWinner = 0;
            for (int j = 0; j < listOfPlayers.Count; j++)
            {
                int value = 0;
                for (int i = 0; i < listOfPlayers[j].listOfCards.Count; i++)
                {
                    value += listOfPlayers[j].listOfCards[i].value;
                }
                if (value <= 21)
                {
                    if (winnerValue < value)
                    {
                        winnerValue = value;
                        indexOfWinner = j;
                    }
                }
            }
            if (winnerValue == 0)
            {
                return null;
            }
            return listOfPlayers[indexOfWinner].Id.ToString();
        }
        /// <summary>
        /// Adds player to a blackjack game.
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(Player player)
        {
            this.listOfPlayers.Add(player);
        }
        /// <summary>
        /// Adds interface of player to a blackjack game.
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(IPlayer player)
        {
            this.listOfPlayers.Add(player);
        }
    }
    public interface IBlackjack
    {
        List<IPlayer> listOfPlayers { get; }
        public void AddPlayer(Player player);
    }
}
