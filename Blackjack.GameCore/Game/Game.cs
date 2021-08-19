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
        // Если значение параметра - “Hit“ (взять еще одну карту), то
        //a Раздать еще 1 карту из колоды игроку. 
        //Если колода закончилась - поменять статус игры на “колода закончилась”, 
        //и вернуться из метода.
        //b  Проверить, сколько очков у игрока.
        //Если больше 21 - то игрок проиграл, поменять статус игры на “победа дилера”. 
        //Иначе - передать ход дилеру (поменять статус игры).
        //3 Если значение параметра - “Stay”, то карты брать не нужно.
        //Передать ход дилеру(поменять статус игры).
        {
            if (Status != GameStatus.PlayerTurn)
            {
                throw new InvalidOperationException("MakeAction should be called when Game status is PlayerTurn");
            }
            else
            {
                if (action == PlayerAction.Hit)
                {
                    if (!AddCardToHand(PlayerHand))         //выдана 1карта  игроку
                    {
                        Status = GameStatus.DeckFinished;
                       // break; ////
                    }
                    else
                    {
                        if (PlayerHand.Points >21)
                        {
                            Status = GameStatus.DealerWon;
                        }
                        else
                        {
                            Status = GameStatus.DealerTurn;  ////непонятно, вроде не должен быть переход
                        }
                    }
                };
                if (action == PlayerAction.Stay)
                {
                    Status = GameStatus.DealerTurn;
                }
            }
        }

        public void MakeDealerMove()
        {
            if (Status != GameStatus.DealerTurn)
            {
                throw new InvalidOperationException("MakeDealerMove should be called when Game status is DealerTurn");
            }
            else
            {
                while(DealerHand.Points < 17) 
                    //дилер должен тянуть карты до тех пор, пока сумма его очков не будет 17 или больше.
                    //Если колода закончилась - поменять статус игры на “колода закончилась”, 
                    //и вернуться из метода.
                {
                    if (!AddCardToHand(DealerHand))
                    {
                        Status = GameStatus.DeckFinished;
                        break;
                    }
                };
                GameWinner(); // подсчет очков
            }
        }

        public void DealCards()
        {            
            if (Status != GameStatus.New)
            {
                throw new InvalidOperationException("DealCards should be called when Game status is New");
            }
            else   
            {               
                if (!AddCardToHand(DealerHand))      //выдана 1карта  дилеру
                {
                    Status = GameStatus.DeckFinished ;
                }
                else    
                {
                    if (!AddCardToHand(DealerHand))  //выдана 2карта  дилеру
                    {
                        Status = GameStatus.DeckFinished;
                    }
                    else    
                    {
                        if (!AddCardToHand(PlayerHand))         //выдана 1карта  игроку
                        {
                            Status = GameStatus.DeckFinished;
                        }
                        else   
                        {
                            if (!AddCardToHand(PlayerHand))      //выдана 2карта  игроку
                            {
                                Status = GameStatus.DeckFinished;
                            }
                            else
                            {
                                Status = GameStatus.PlayerTurn;
                            }
                        }
                    }
                }
            }
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

        private  bool GameDeckFinished()
            {
                return Status == GameStatus.DeckFinished;
            }

        private void GameWinner()
        {
            //Проверить очки и в зависимости от результата поменять статус игры:
            //Если у дилера 21, а у игрока нет -дилер победил
            //Если у обоих 21 - ничья
            //Если у дилера больше, чем 21 - игрок выиграл
            //Если у обоих одинаковое количество(не 21) -ничья
            //Иначе победил тот, у кого больше очков.
            var player = PlayerHand.Points;
            var dealer = DealerHand.Points;

            if (dealer == 21)
            {
                if (player != 21)
                {
                    Status = GameStatus.DealerWon;
                }
                else
                {
                    if (player == 21)
                    {
                        Status = GameStatus.Equal;
                    }
                }
            }
            else
            {
                if(dealer > 21)
                {
                    Status = GameStatus.PlayerWon;
                }
                else
                {
                    if(dealer == player)
                    {
                        Status = GameStatus.Equal;
                    }
                    else
                    {
                        if(dealer > player)
                        {
                            Status = GameStatus.DealerWon;
                        }
                        else 
                        {
                            Status = GameStatus.PlayerWon;
                        }
                    }
                }
            }

        }
            
        
    }
}
