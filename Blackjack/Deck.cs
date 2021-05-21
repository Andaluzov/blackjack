using System;


namespace Blackjack.Decks
{
    public class Deck
    {
        int price;
       
        const int n = 13;
        string[] dec = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public string GetDeck()
        {
            Random a = new Random();
            string card = dec[a.Next(0, 12)];
            //Console.WriteLine(card);
            return card;
        }
            
    }
}
