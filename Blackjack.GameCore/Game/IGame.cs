using Blackjack.GameCore.Enums;

namespace Blackjack.GameCore.Game
{
    public interface IGame
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
