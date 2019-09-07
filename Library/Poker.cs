using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public static class Poker
    {
        public static Card HighCard(List<Card> pokerHand)
        {
            return pokerHand
                    .OrderByDescending(x => x.Rank)
                    .FirstOrDefault();
        }

        public static bool IsPair(List<Card> pokerHand)
        {
            return pokerHand
                    .GroupBy(x => x.Rank)
                    .ToDictionary(g => g.Key, g => g.Count())
                    .Any(x => x.Value == 2);
        }

        public static bool IsTwoPair(List<Card> pokerHand)
        {
            return pokerHand
                    .GroupBy(x => x.Rank)
                    .ToDictionary(g => g.Key, g => g.Count())
                    .Count(x => x.Value == 2) == 2;
                    
        }

        public static bool IsThreeOfAKind(List<Card> pokerHand)
        {
            return pokerHand
                    .GroupBy(x => x.Rank)
                    .ToDictionary(g => g.Key, g => g.Count())
                    .Any(x => x.Value == 3);
        }

        public static bool IsFullHouse(List<Card> pokerHand)
        {
            return IsPair(pokerHand) && IsThreeOfAKind(pokerHand); 
        }

        public static bool IsFourOfAKind(List<Card> pokerHand)
        {
            return pokerHand
                    .GroupBy(x => x.Rank)
                    .ToDictionary(g => g.Key, g => g.Count())
                    .Any(x => x.Value == 4);
        }


        public static bool IsFlush(List<Card> pokerHand)
        {
            return pokerHand
                    .GroupBy(x => x.Suit)
                    .ToDictionary(g => g.Key, g => g.Count())
                    .Any(x => x.Value == 5);
        }

        public static bool IsStraight(List<Card> pokerHand)
        {
            var hand = pokerHand.OrderBy(x => x.Rank).ToList();
            
            for (int i = 0; i < hand.Count - 1; i++)
            {
                if (hand[i].Rank != hand[i + 1].Rank - 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsStraightFlush(List<Card> pokerHand)
        {
            return IsStraight(pokerHand) && IsFlush(pokerHand);
        }

        public static bool IsRoyalFlush(List<Card> pokerHand)
        {
            return IsStraight(pokerHand) && IsFlush(pokerHand) && HighCard(pokerHand).Rank == Rank.Ace;
        }
    }
}
