using System;

namespace Blackjack.GameCore.Enums
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
