using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
#region Enums
    enum Suit { Hearts = 1, Spades, Diamonds, Clubs }
    enum Value { Two = 2, Three = 3, Four = 4, Five = 5, Six = 6,
        Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11,
        Queen = 12, King = 13, Ace = 14 }
    enum Symbol { Hearts = 'H', Spades = 'S', Diamonds = 'D', Clubs = 'C' }
    // Unicode characters "\u2665", "\u2660", "\u2666", "\u2663" ?
#endregion
    struct Card : IComparable
    {
        private Value _value;
        private Suit _suit;

        public Value Value
        {
            get { return _value; }
        }

        public Suit Suit
        {
            get { return _suit; }
        }

        public char SuitSymbol
        {
            get
            {
                // return symbol based on suit
                return (char)(Symbol)Enum.Parse(
                    typeof(Symbol), _suit.ToString());
            }
        }

        public string ValueSymbol
        {
            get
            {
                switch ((int)_value)
                {
                    case 11: return "J";
                    case 12: return "Q";
                    case 13: return "K";
                    case 14: return "A";
                    default: return ((int)_value).ToString();
                }
            }
        }

        public Card(Value value, Suit suit)
        {
            _value = value;
            _suit = suit;
        }

        public int CompareTo(object obj)
        {
            var obj1 = (int)Value;
            var obj2 = (int)((Card)obj).Value;
            return obj1.CompareTo(obj2);
        }
    }
}
