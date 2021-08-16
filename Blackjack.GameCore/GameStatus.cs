using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.GameCore
{
    public enum GameStatus
    {
        New,
        PlayerTurn,
        DealerTurn,
        DealerWon,
        PlayerWon,
        Equal,
        DeckFinished
    }
}
