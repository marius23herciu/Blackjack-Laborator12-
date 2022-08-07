using Blackjack_Laborator12_.DeckOfCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Laborator12_.Interfaces
{
    public interface IPlayer
    {
        Guid Id { get; }

        List<Card> listOfCards { get; }

    }
}
