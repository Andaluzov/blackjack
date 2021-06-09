using System;
using System.Collections.Generic;

namespace Blackjack.GameCore
{
    public class Card
    {
        public int Value { get; }

        public SuitType Suit { get; }

        public string Rank
        {
            get
            {
                return GetRank();  // цена карты
            }
        }

        public Card (int value, SuitType suit)
        {
            Value = value;
            Suit = suit;
            
        }

        string GetRank()
        {
            string tempRank;

            switch (Value)
            {
                case 11:
                    tempRank = " Jack";
                    break;

                case 12:
                    tempRank = "Queen";
                    break;

                case 13:
                    tempRank = "King";
                    break;

                case 14:
                    tempRank = "Ace";
                    break;
                default:
                    tempRank = Value.ToString();
                    break;
            }

            return tempRank;
        }
    }
}
