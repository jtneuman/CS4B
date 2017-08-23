using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfCards
{
    public partial class Form1 : Form
    {

        enum Suit { Hearts = 1, Spades, Diamonds, Clubs }
        enum Value { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight,
            Nine, Ten, Jack, Queen, King }

        struct Card
        {
            private Suit _suit;
            private Value _value;

            public Value Value { get { return _value; } }
            public Suit Suit { get { return _suit; } }

            public Card(Value value, Suit suit)
            {
                _value = value;
                _suit = suit;
            }
        }

        Stack<Card> deck = new Stack<Card>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int value = 1; value <= 13; value++)
                for (int suit = 1; suit <= 4; suit++)
                    deck.Push(new Card((Value)value, (Suit)suit));
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if(deck.Count > 0)
            {
                var card = deck.Pop();
                lstCards.Items.Add(String.Format("{0} of {1}", card.Value,
                    card.Suit));
            }
        }
    }
}
