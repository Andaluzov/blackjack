﻿using System;
using Blackjack.GameCore;

namespace Blackjack.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Deck deck = new Deck();

            Console.WriteLine(deck.GetCard());
        }
    }
}
