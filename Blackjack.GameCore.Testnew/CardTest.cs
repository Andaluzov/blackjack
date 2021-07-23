using Blackjack.GameCore;
using System;
using Xunit;

namespace Blackjack.GameCore.Test
{
    public class CardTest
    {
        [Fact]
        public void RankTest11()
        {
            string expected = "Jack";
            Card c = new Card(11, SuitType.Clubs);
            string actual = c.Rank;
            Assert.Equal(expected, actual);
        }
   
        [Theory]
        [InlineData(11, "Jack")]
        [InlineData(12, "Queen")]
        [InlineData(13, "King")]
        [InlineData(14, "Ace")]
        [InlineData(2, "2")]
        public void CanGetRank(int value, string expected) 
        {
            Card c = new Card(value, SuitType.Clubs);
            string result = c.Rank;
            Assert.Equal(expected, result);
        }

    }
    
}
