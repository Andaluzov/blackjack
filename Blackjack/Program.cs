using System;
using Blackjack.Decks;


namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck deck = new Deck();

            Console.WriteLine(deck.GetDeck());
        }
    }
}
