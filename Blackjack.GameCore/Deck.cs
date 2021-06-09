using System;
using System.Collections.Generic;


namespace Blackjack.GameCore
{
    public class Deck
    {
        private List<Card> _cards; // может создать  пустой список? = new List<Card>{}- см строку 17


        //{ "2", "3", "4", "5", "6", "7", "8", "9", "10", " Jack", "Queen", "King", "Ace" }


        public Deck()
        {
            _cards = new List<Card> { };
            for (int i = 2; i < 14; i++)
            {
                _cards.Add(new Card(i, SuitType.Clubs));
                _cards.Add(new Card(i, SuitType.Diamonds));
                _cards.Add(new Card(i, SuitType.Hearts));
                _cards.Add(new Card(i, SuitType.Spades));
            }
            Shuffle();
        }
        
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < _cards.Count; i++)
            {
                int k = rnd.Next(0, i);
                Card tempCard = _cards[k];
                _cards[k] = _cards[i];
                _cards[i] = tempCard;
            }
            
        }
        public bool TryGetCard(out Card firstCard)
        {
            if (_cards.Count == 0)
            {
                //firstCard = new Card(2, SuitType.Clubs);// уточнить пустую карту
                firstCard =  _cards[_cards.Count]; //последняя карта в списке, если он пустой
                return false;
            }
            else
            {
                firstCard = _cards[0];
                _cards.RemoveAt(0);
                return true;

            }
            

        }

                    
    }
}
