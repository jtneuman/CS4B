using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Poker : Form
    {
        #region Variables
        Hand playerHand;
        Hand dealerHand;
        List<Card> deck;
        const int shuffles = 1000;
        #endregion

        public Poker()
        {
            InitializeComponent();
        }

        private void Poker_Load(object sender, EventArgs e)
        {

        }

        #region Methods

        private void Initialize()
        {
            playerHand = new Hand();
            dealerHand = new Hand();
            deck = new List<Card>();
        }

        private void ShuffleDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    var card = new Card(value, suit);
                    deck.Add(card);
                }
            }
            Random rnd = new Random();

            for (int i = 0; i < shuffles; i++)
            {
                List<Card> tmpDeck = new List<Card>();
                while (deck.Count > 0)
                {
                    var index = rnd.Next(deck.Count);

                    var card = deck[index];
                    deck.RemoveAt(index);
                    tmpDeck.Add(card);
                }
                deck = tmpDeck;
            }

        }

        private void DealCards()
        {
            playerHand.Cards = new Card[5];
            dealerHand.Cards = new Card[5];

            for (int i = 0; i < 5; i++)
            {
                playerHand.Cards[i] = deck.ElementAt(0);
                dealerHand.Cards[i] = deck.ElementAt(1);
                deck.RemoveRange(0, 2);
            }
        }

        private void EvaluateHand(ref Hand evalHand)
        {
            #region Arranging cards
            Array.Sort(evalHand.Cards);
            var suit1 = evalHand.Cards[0].Suit;
            var suit2 = evalHand.Cards[1].Suit;
            var suit3 = evalHand.Cards[2].Suit;
            var suit4 = evalHand.Cards[3].Suit;
            var suit5 = evalHand.Cards[4].Suit;
            var value1 = evalHand.Cards[0].Suit;
            var value2 = evalHand.Cards[1].Suit;
            var value3 = evalHand.Cards[2].Suit;
            var value4 = evalHand.Cards[3].Suit;
            var value5 = evalHand.Cards[4].Suit;
            #endregion

            #region Has Flush? 
            var hasFlush = evalHand.Cards.Count(
                c => c.Suit.Equals(suit1)).Equals(5));
            if (hasFlush)
            {
                evalHand.Suit = (int)suit1;
                evalHand.HandValue = Hands.Flush;
            }
            #endregion
        }

        #endregion



        private void btnDeal_Click(object sender, EventArgs e)
        {
            Initialize();
            ShuffleDeck();
            DealCards();
        }
    }
}
