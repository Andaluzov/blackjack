using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Acceptance criteria(AC):
/// This class must store a list of cards (for one “hand”) and points for these cards. 
/// The users of this class should not be able to change points and remove cards from the hand.
/// This class must have a constructor.
/// This class must have a way to add cards to card list and to update the points.
/// Create tests for the Hand class.
/// </summary>
namespace Blackjack.GameCore
{
    public class Hand
    {
        public List<Card> Cards {get; private set;}

        public int Points {get; private set;}

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
            this.Points = GetPoints();
        }

        private int GetPoints()
        {
            int tempRank = 0;
            for (int i = 0; i < Cards.Count; i++)
            {
                tempRank += GetPointsForRank(Cards[i].Value);
                if (tempRank > 21)
                {
                    tempRank -= 10;
                }
            }
            return tempRank;
        }

        private int GetPointsForRank(int value)
        {
            if (value < 11)
            {
                return value;
            }
            else
            {
                if (value == 14)
                {
                    return 11;
                }
                else
                {
                    return 10;
                }
            }
        }
    }
}