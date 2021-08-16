using System;
using Blackjack.GameCore.Enums;

namespace Blackjack.GameCore.Game
{
    public class Game : IGame
    {
        public Deck Deck { get; }
        public Hand DealerHand { get; }
        public Hand PlayerHand { get; }
        public GameStatus Status { get; private set; }

        public Game()
        {
            Deck = new Deck();
            Status = GameStatus.New;
            DealerHand = new Hand();
            PlayerHand = new Hand();
        }

        public void MakeAction(PlayerAction action)
        {

        }

        public void MakeDealerMove()
        {

        }

        public void DealCards()
        {            
            if (Status != GameStatus.New)
            {
                throw new InvalidOperationException("DealCards should be called when Game status is New");
            }


            //else
            //{ 
            //    bool dealStatus = !Deck.TryGetCard(out Card _card); //выдана 1карта  дилеру
            //    if (!dealStatus)
            //    {
            //        Status = GameStatus.DeckFinished;
            //    }
            //    else
            //    {
            //        DealerHand.AddCard(_card);
            //        Status = GameStatus.DealerTurn;
            //        dealStatus = !Deck.TryGetCard(out Card _card); //выдана 2карта  дилеру
            //        if (!dealStatus)
            //        {
            //            Status = GameStatus.DeckFinished;
            //        }
            //        else
            //        {
            //            DealerHand.AddCard(_card);
            //            Status = GameStatus.PlayerTurn;
            //        };
            //        dealStatus = !Deck.TryGetCard(out Card _card); //выдана 1карта  игроку
            //        if (!dealStatus)
            //        {
            //            Status = GameStatus.DeckFinished;
            //        }
            //        else
            //        {
            //            PlayerHand.AddCard(_card);
            //            Status = GameStatus.PlayerTurn;
            //            dealStatus = !Deck.TryGetCard(out Card _card); //выдана 2карта  игроку
            //            if (!dealStatus)
            //            {
            //                Status = GameStatus.DeckFinished;
            //            }
            //            else
            //            {
            //                PlayerHand.AddCard(_card);
            //                Status = GameStatus.PlayerTurn;
            //            }
            //        }
            //    }
            //}
        }

        private bool AddCardToHand(Hand hand)
        {
            if (Deck.TryGetCard(out Card card))
            {
                hand.AddCard(card);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
