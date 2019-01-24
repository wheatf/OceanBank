using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    public partial class GUIforATM : Form
    {
        private CardReader theCardReader;
        private CashDispenser theCashDispenser;
        private State currentState;
        private List<Card> cards;
        private Card theCard;
        private SoundPlayer keysound;

        public GUIforATM(List<Card> c)
        {
            InitializeComponent();

            cards = c;

            theCardReader = new CardReader(rightPicBox);
            theCardReader.withoutCard();
            theCashDispenser = new CashDispenser(leftPicBox);
            theCashDispenser.withoutCash();

            keysound = new SoundPlayer(Properties.Resources.keysound);
            keysound.Load();

            currentState = new WaitForBankCardState(this, "ENGLISH");
        }

        public CardReader getCardReader()
        {
            return theCardReader;
        }

        public CashDispenser getCashDispenser()
        {
            return theCashDispenser;
        }

        public void setCard(Card card)
        {
            theCard = card;
        }

        public Card getCard()
        {
            return theCard;
        }

        public List<Card> getAllCards()
        {
            return cards;
        }

        private void leftPicBox_Click(object sender, EventArgs e)
        {
            currentState = currentState.handleLeftPicBoxClick();
        }

        private void rightPicBox_Click(object sender, EventArgs e)
        {
            currentState = currentState.handleRightPicBoxClick();
        }

        private void key1BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey1BTNClick();
        }

        private void key2BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey2BTNClick();
        }

        private void key3BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey3BTNClick();
        }

        private void key4BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey4BTNClick();
        }

        private void key5BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey5BTNClick();
        }

        private void key6BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey6BTNClick();
        }

        private void key7BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey7BTNClick();
        }

        private void key8BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey8BTNClick();
        }

        private void key9BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey9BTNClick();
        }

        private void key0BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleKey0BTNClick();
        }

        private void left1BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleLeft1BTNClick();
        }

        private void left2BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleLeft2BTNClick();
        }

        private void left3BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleLeft3BTNClick();
        }

        private void left4BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleLeft4BTNClick();
        }


        private void right1BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleRight1BTNClick();
        }

        private void right2BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleRight2BTNClick();
        }

        private void right3BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleRight3BTNClick();
        }

        private void right4BTN_Click(object sender, EventArgs e)
        {
            keysound.Play();
            currentState = currentState.handleRight4BTNClick();
        }

        private void GUIforATM_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.D1:
                case (char)Keys.NumPad1:
                    keysound.Play();
                    currentState = currentState.handleKey1BTNClick();
                    break;

                case (char)Keys.D2:
                case (char)Keys.NumPad2:
                    keysound.Play();
                    currentState = currentState.handleKey2BTNClick();
                    break;

                case (char)Keys.D3:
                case (char)Keys.NumPad3:
                    keysound.Play();
                    currentState = currentState.handleKey3BTNClick();
                    break;

                case (char)Keys.D4:
                case (char)Keys.NumPad4:
                    keysound.Play();
                    currentState = currentState.handleKey4BTNClick();
                    break;

                case (char)Keys.D5:
                case (char)Keys.NumPad5:
                    keysound.Play();
                    currentState = currentState.handleKey5BTNClick();
                    break;

                case (char)Keys.D6:
                case (char)Keys.NumPad6:
                    keysound.Play();
                    currentState = currentState.handleKey6BTNClick();
                    break;

                case (char)Keys.D7:
                case (char)Keys.NumPad7:
                    keysound.Play();
                    currentState = currentState.handleKey7BTNClick();
                    break;

                case (char)Keys.D8:
                case (char)Keys.NumPad8:
                    keysound.Play();
                    currentState = currentState.handleKey8BTNClick();
                    break;

                case (char)Keys.D9:
                case (char)Keys.NumPad9:
                    keysound.Play();
                    currentState = currentState.handleKey9BTNClick();
                    break;

                case (char)Keys.D0:
                case (char)Keys.NumPad0:
                    keysound.Play();
                    currentState = currentState.handleKey0BTNClick();
                    break;
            }
        }
    }
}
