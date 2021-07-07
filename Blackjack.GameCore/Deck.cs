using System;
using System.Collections.Generic;

namespace Blackjack.GameCore
{
    public class Deck
    {
        private List<Card> _cards; 
        
        public Deck()
        {
            _cards = new List<Card>();
            for (int i = 2; i < 15; i++)
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
                firstCard = null;
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
