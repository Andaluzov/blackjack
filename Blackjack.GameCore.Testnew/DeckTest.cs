using Blackjack.GameCore;
using System;
//using System.Collections.Generic;
using Xunit;

/// <summary>
/// Write tests that will check:
/// the number of cards in the deck is correct;
/// the deck can return a card.
/// </summary>
/// 
namespace Blackjack.GameCore.Test
{
    public class DeckTest
    {
        [Fact]
        public void DeckTryGetCardTest()  //the deck can return a card
        {
            Deck deck = new Deck();
            var returnACard = deck.TryGetCard(out _); // карта firstCard выдана
            Assert.True(returnACard);
        }

        [Fact]
        public void DeckNumberOfCardsTest()    //the number of cards in the deck is correct;
        {            
            Deck deck = new Deck();            
            int expected = 52;                 //numberDeck              
            int actual = 0;
            while (deck.TryGetCard(out _))
            {
                actual++;                
            }            
            Assert.Equal(expected, actual);
        }
    }
}
