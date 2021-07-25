﻿using Blackjack.GameCore;
using System.Collections.Generic;
using System;
using Xunit;

namespace Blackjack.GameCore.Test
{
    public class HandTest
    {
<<<<<<< HEAD
        private int SearchPlayer(List<int>numbers)
=======
        readonly int[] numbers1 = {6, 3, 11};
        readonly int[] numbers2 = {6, 5, 11};

        [Fact]
        public void CanGetPoints()
>>>>>>> dee3edb106a21b6803fc45d9cb69e6fb2a050838
        {
            Hand player = new Hand();
            for (int i = 0; i < numbers.Count; i++)
            player.AddCard(new Card(numbers[i], SuitType.Diamonds));
            return  player.Points;
        }
        [Fact]
        public void CanGetPoints1()
        {
            int expected = 12;                 //numberDeck 
            List<int> numbers = new List<int> { 6, 5, 14 };
            int actual = SearchPlayer(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGetPoints2()
        {
            int expected = 15;                 //numberDeck 
            List<int> numbers = new List<int> { 1, 3, 14, 11 };
            int actual = SearchPlayer(numbers);
            Assert.Equal(expected, actual);
        }
  
        [Fact]
        public void CanGetPoints3()
        {
            int expected = 20;                 //numberDeck
            List<int> numbers = new List<int> { 6, 3, 14 };
            int actual = SearchPlayer(numbers);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CanGetPoints4()
        {
            int expected = 6;                 //numberDeck
            List<int> numbers = new List<int> { 6 };
            int actual = SearchPlayer(numbers);
            Assert.Equal(expected, actual);
        }

    }
}
