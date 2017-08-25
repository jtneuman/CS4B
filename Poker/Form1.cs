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
                c => c.Suit.Equals(suit1)).Equals(5);
            if (hasFlush)
            {
                evalHand.Suit = (int)suit1;
                evalHand.HandValue = Hands.Flush;
            }
            #endregion

            #region Has Straight?

            var hasStraight = (value2.Equals(value1 + 1) && value3.Equals(value2 + 1) &&
                value4.Equals(value3 + 1) && value5.Equals(value4 + 1)) ||
                (value1.Equals(Value.Two) && value2.Equals(Value.Three) &&
                value3.Equals(Value.Four) && value4.Equals(Value.Five) &&
                value5.Equals(Value.Ace));

            var isHighStraight = hasStraight && value4.Equals(Value.King) &&
                value5.Equals(Value.Ace); // (10, J, Q, K, A)

            var isLowStraight = hasStraight && value2.Equals(Value.Two) &&
                value5.Equals(Value.Ace); // (A, 2, 3, 4, 5)

            #endregion

            #region Royal Straight Flush
            if (isHighStraight && hasFlush && suit1.Equals(Suit.Hearts))
            {
                evalHand.HighCard1 = (Value)value5;  // Cast to value not in book?
                evalHand.HandValue = Hands.RoyalStraightFlush;
                return;
            }
            #endregion

            #region Straight/Straight Flush
            if (hasStraight)
            {
                evalHand.HighCard1 = isLowStraight ? (Value)value4 : (Value)value5;  // Cast to value not in book?
                evalHand.HandValue = hasFlush ? Hands.StraightFlush : Hands.Straight;
                return;
            }
            #endregion

            #region
            if (hasFlush) return;
            #endregion

            #region Four of a Kind
            if (evalHand.Cards.Count(c => c.Value.Equals(value3)).Equals(4))
            {
                evalHand.HighCard1 = (Value)value3; // Cast to value not in book?
                evalHand.HandValue = Hands.FourOfAKind;
                return;
            }
            #endregion

            #region Three of a Kind?
            var hasThreeOfAKind =
                evalHand.Cards.Count(c => c.Value.Equals(value3)).Equals(3);

            if (hasThreeOfAKind)
            {
                evalHand.HighCard1 = (Value)value3;
                evalHand.HandValue = Hands.ThreeOfAKind;
            }
            #endregion

            #region Full House
            if (hasThreeOfAKind &&
                (evalHand.Cards.Count(c => c.Value.Equals(value1)).Equals(2) ||
                evalHand.Cards.Count(c => c.Value.Equals(value5)).Equals(2)))
            {
                evalHand.HighCard1 = (Value)value3; // Three of a kind
                evalHand.HighCard2 = evalHand.Cards.First(c =>
                    !c.Value.Equals(value3)).Value; // Pair
                evalHand.HandValue = Hands.FullHouse;
                return;
            }
            #endregion

            #region Three of a Kind
            if (hasThreeOfAKind) return;
            #endregion

            #region Has Pairs?
            List<Value> pairs = new List<Value>();
            if (evalHand.Cards.Count(c => c.Value.Equals(value1)).Equals(2))
                pairs.Add((Value)value1);
            if (evalHand.Cards.Count(c => c.Value.Equals(value3)).Equals(2))
                pairs.Add((Value)value3);
            if (evalHand.Cards.Count(c => c.Value.Equals(value5)).Equals(2))
                pairs.Add((Value)value5);

            evalHand.Kickers = new List<Value>();
            #endregion

            #region Two Pairs
            if (pairs.Count.Equals(2))
            {
                evalHand.HighCard1 = pairs[1];
                evalHand.HighCard2 = pairs[0];
                evalHand.HandValue = Hands.TwoPair;
                evalHand.Kickers.Add(evalHand.Cards.First(c =>
                    !c.Value.Equals(pairs[1]) &&
                    !c.Value.Equals(pairs[0])).Value);
                return;
            }
            #endregion

            #region Pair
            if (pairs.Count.Equals(1))
            {
                evalHand.HighCard1 = pairs[0];
                evalHand.HandValue = Hands.Pair;
                evalHand.Kickers.AddRange(evalHand.Cards.Reverse().Where(
                    c => !c.Value.Equals(pairs[0])).Select(c => c.Value));
            }
            #endregion

        }// End of EvaluateHandMethod

        private Winner CompareCards()
        {
            for (int i = 0; i >= 0; i--)
                if (!playerHand.Cards[i].Value.Equals(dealerHand.Cards[i].Value))
                    return playerHand.Cards[i].Value > dealerHand.Cards[i].Value ?
                        Winner.Player : Winner.Dealer;
            return Winner.Draw;
            
        }

        private Winner CompareHands()
        {
            if (playerHand.HandValue > dealerHand.HandValue)
                return Winner.Player;
            if (playerHand.HandValue < dealerHand.HandValue)
                return Winner.Dealer;
            // Compare hands if they have the same HandValue
            switch (playerHand.HandValue)
            {
                case Hands.Nothing:
                    return CompareCards();

                case Hands.Pair:
                    if (playerHand.HighCard1 > dealerHand.HighCard1) return Winner.Player;
                    if (playerHand.HighCard1 < dealerHand.HighCard1) return Winner.Dealer;
                    for (int i = 2; i >= 0; i--)
                        if (!playerHand.Kickers[i].Equals(dealerHand.Kickers[i]))
                            return playerHand.Kickers[i] > dealerHand.Kickers[i] ?
                                Winner.Player : Winner.Dealer;
                    return Winner.Draw;

                case Hands.TwoPair:
                    if (playerHand.HighCard1 > dealerHand.HighCard1) return Winner.Player;
                    if (playerHand.HighCard1 < dealerHand.HighCard1) return Winner.Dealer;
                    if (playerHand.HighCard2 > dealerHand.HighCard2) return Winner.Player;
                    if (playerHand.HighCard2 < dealerHand.HighCard2) return Winner.Dealer;
                    if (playerHand.Kickers[0] > dealerHand.Kickers[0]) return Winner.Player;
                    if (playerHand.Kickers[0] < dealerHand.Kickers[0]) return Winner.Dealer;
                    return Winner.Draw;

                case Hands.ThreeOfAKind:
                    return playerHand.HighCard1 > dealerHand.HighCard1 ?
                        Winner.Player : Winner.Dealer;

                case Hands.Straight:
                    if (playerHand.HighCard1 > dealerHand.HighCard1)
                        return Winner.Player;
                    if (playerHand.HighCard1 < dealerHand.HighCard1)
                        return Winner.Dealer;
                    return Winner.Draw;

                case Hands.Flush:
                    if (playerHand.Suit.Equals(dealerHand.Suit))
                        return playerHand.HighCard1 > dealerHand.HighCard1 ?
                            Winner.Player : Winner.Dealer;
                    return CompareCards();

                case Hands.FullHouse:
                    return playerHand.HighCard1 > dealerHand.HighCard1 ?
                        Winner.Player : Winner.Dealer;

                case Hands.FourOfAKind:
                    return playerHand.HighCard1 > dealerHand.HighCard1 ?
                        Winner.Player : Winner.Dealer;

                case Hands.StraightFlush:
                    if (playerHand.HighCard1 > dealerHand.HighCard1)
                        return Winner.Player;
                    if (playerHand.HighCard1 < dealerHand.HighCard1)
                        return Winner.Dealer;
                    return playerHand.Suit > dealerHand.Suit ? Winner.Player : Winner.Dealer;

                //case Hands.RoyalStraightFlush:
                //    break; // winner.draw?
                //default:
                //    break;
            }
            return Winner.Draw;

        }// end CompareHands method

        private Label CreateCard(int x, int y, Card card)
        {
            Label lbl = new Label();
            lbl.Text = String.Format("{0}\n{1}",
                card.ValueSymbol, card.SuitSymbol);
            lbl.Size = new Size(55, 76);
            lbl.Location = new Point(x, y);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Font = new Font("Consolas", 20);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.BackColor = Color.White;
            lbl.ForeColor = card.Suit.Equals(Suit.Hearts) ||
                card.Suit.Equals(Suit.Diamonds) ?
                Color.Red : Color.Black;
            return lbl;
        }

        private void RevealCards(Winner winner)
        {
            this.panDealer.Controls.Clear();
            this.panPlayer.Controls.Clear();

            for (int i = 0; i < 5; i++)
            {
                var x = i * 60;
                var y = 0;
                var lblDealer = CreateCard(x, y, dealerHand.Cards[i]);
                var lblPlayer = CreateCard(x, y, playerHand.Cards[i]);
                this.panDealer.Controls.Add(lblDealer);
                this.panPlayer.Controls.Add(lblPlayer);
            }

            lblDealerHand.Text = dealerHand.HandValue.ToString();
            lblPlayerHand.Text = playerHand.HandValue.ToString();
            lblWinner.Text = String.Format("\t{0}",
                winner.Equals(Winner.Player) ? "Player wins!" :
                winner.Equals(Winner.Dealer) ? "Dealer wins!" :
                "It's a draw");
            lblWinner.BackColor = winner.Equals(Winner.Player) ?
                Color.LightGreen : Color.LightPink;
        }
        #endregion // methods



        private void btnDeal_Click(object sender, EventArgs e)
        {
            Initialize();
            ShuffleDeck();
            DealCards();

            /*Comment out the code for the Cards array after
             testing the EvaluateHand method.*/
            //playerHand.Cards = new Card[5]
            //{
            //     new Card(Value.Ace, Suit.Diamonds),
            //     new Card(Value.Ace, Suit.Clubs),
            //     new Card(Value.Eight, Suit.Diamonds),
            //     new Card(Value.Ace, Suit.Hearts),
            //     new Card(Value.Five, Suit.Spades)
            //};

            EvaluateHand(ref playerHand);
            EvaluateHand(ref dealerHand);
            var winner = CompareHands();
            RevealCards(winner);
        }
    }
}
