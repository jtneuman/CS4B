using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    enum Hands { Nothing, Pair, TwoPair, ThreeOfAKind, Straight, Flush,
        FullHouse, FourOfAKind, StraightFlush, RoyalStraightFlush }
    enum Winner { Dealer, Player, Draw }

    struct Hand
    {
        public Card[] Cards { get; set; }
        public Hands HandValue { get; set; }
        public Value HighCard1 { get; set; }
        public Value HighCard2 { get; set; }
        public List<Value> Kickers { get; set; }
        public int Suit { get; set; }

    }
}
