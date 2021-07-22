using Blackjack.GameCore;
using System.Collections.Generic;
using System;
using Xunit;

namespace Blackjack.GameCore.Test
{
    public class HandTest
    {
        readonly int[] numbers1 = {6, 3, 11};
        readonly int[] numbers2 = {6, 5, 11};

        [Fact]

        public void CanGetPoints()
        {
            // Deck deck = new Deck();
            int expected = 12;                 //numberDeck              
            
            Hand player = new Hand();
            player.AddCard(new Card(6, SuitType.Diamonds));
            player.AddCard(new Card(5, SuitType.Diamonds));
            player.AddCard(new Card(14, SuitType.Diamonds));

            int actual = player.Points;
            Assert.Equal(expected, actual);
        }
        
    }
}
