using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.GameCore.Game
{
    interface IGame
    {
        public Deck Deck { get; }
        public Hand DealerHand { get; }
        public Hand PlayerHand { get; }
        public GameStatus Status { get; }

        void MakeAction(PlayerAction action);
        void MakeDealerMove();
        void DealCards();
    }
}
