using Library;
using System;
using System.Collections.Generic;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void CanDescribeCard()
        {
            var card = new Card(Rank.Ace, Suit.Spades);

            Assert.Equal("Ace of Spades", card.ToString());
        }

        [Fact]
        public void HighCardTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Spades),
                new Card(Rank.Nine, Suit.Diamonds),
                new Card(Rank.Ten, Suit.Diamonds),
                new Card(Rank.Seven, Suit.Diamonds),
            };

            var highCard = Poker.HighCard(pokerHand);

            Assert.Equal(Rank.Ace, highCard.Rank);
        }

        [Fact]
        public void IsPairTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Ace, Suit.Spades),
                new Card(Rank.Nine, Suit.Diamonds),
                new Card(Rank.Ten, Suit.Diamonds),
                new Card(Rank.Seven, Suit.Diamonds),
            };

            Assert.True(Poker.IsPair(pokerHand));
        }

        [Fact]
        public void IsTwoPairTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Ace, Suit.Spades),
                new Card(Rank.Nine, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Spades),
                new Card(Rank.Seven, Suit.Diamonds),
            };
            
            Assert.True(Poker.IsTwoPair(pokerHand));
        }

        [Fact]
        public void IsThreeOfAKindTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Ace, Suit.Spades),
                new Card(Rank.Ace, Suit.Clubs),
                new Card(Rank.Ten, Suit.Diamonds),
                new Card(Rank.Seven, Suit.Diamonds),
            };

            Assert.True(Poker.IsThreeOfAKind(pokerHand));
        }

        [Fact]
        public void IsFullHouseTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Ace, Suit.Spades),
                new Card(Rank.Nine, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Clubs),
                new Card(Rank.Nine, Suit.Spades),
            };
            Assert.True(Poker.IsFullHouse(pokerHand));
        }

        [Fact]
        public void IsFourOfAKindTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Hearts),
                new Card(Rank.Nine, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Clubs),
                new Card(Rank.Nine, Suit.Spades),
            };

            Assert.True(Poker.IsFourOfAKind(pokerHand));
        }


        // ------------------------------------------ //

        [Fact]
        public void IsFlushTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Two, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Diamonds),
                new Card(Rank.Ten, Suit.Diamonds),
                new Card(Rank.Seven, Suit.Diamonds),
            };

            Assert.True(Poker.IsFlush(pokerHand));
        }

        [Fact]
        public void IsStraightTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Two, Suit.Diamonds),
                new Card(Rank.Three, Suit.Spades),
                new Card(Rank.Four, Suit.Diamonds),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Six, Suit.Diamonds),
            };

            Assert.True(Poker.IsStraight(pokerHand));
        }

        [Fact]
        public void IsStraightFlushTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Six, Suit.Diamonds),
                new Card(Rank.Seven, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Diamonds),
            };

            Assert.True(Poker.IsStraightFlush(pokerHand));
        }

        [Fact]
        public void IsRoyalFlushTest_True()
        {
            var pokerHand = new List<Card>(){
                new Card(Rank.Ten, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Diamonds),
                new Card(Rank.Queen, Suit.Diamonds),
                new Card(Rank.King, Suit.Diamonds),
                new Card(Rank.Ace, Suit.Diamonds),
            };

            Assert.True(Poker.IsRoyalFlush(pokerHand));
        }
    }
}

