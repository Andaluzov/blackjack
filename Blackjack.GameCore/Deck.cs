using System;
using System.Collections.Generic;


namespace Blackjack.GameCore
{
    public class Deck
    {
        private List<Card> Cards = new List<Card>();
       

        //{ "2", "3", "4", "5", "6", "7", "8", "9", "10", " Jack", "Queen", "King", "Ace" }


       public Deck() 
       {
            Cards.Add(new Card("2", SuitType.Clubs));
            Cards.Add(new Card("2", SuitType.Diamonds));
            Cards.Add(new Card("2", SuitType.Hearts));
                 
            Cards.Sort();
            Cards = Shuffle(Cards);
       }
        
        public List<Card> Shuffle(List<Card> Cards)
        {
            Random rnd = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int k = rnd.Next(0, i);
                Card card = Cards[k];
                Cards[k] = Cards[i];
                Cards[i] = card;
            }
            return Cards;
        }
        public bool TryGetCard(out card:Card)
        {
            

        }

                    
    }
}
