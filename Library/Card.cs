using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Card : IComparable<Card>
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Rank, Suit); 
        }

        public int CompareTo(Card other)
        {
            return Rank.CompareTo(other.Rank);
        }
    }
}
