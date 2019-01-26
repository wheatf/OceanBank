using OceanBank.Codes.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    class InsertCashDepositState : State
    {
        private string acctNo;
        private double amount;

        private bool cashInserted = false;

        private Timer timer;
        private int counter;

        public InsertCashDepositState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            bigDisplayLBL.Text = "Insert cash into the cash slot\nOnly notes of SGD 10, 50, 100, 1000 are allowed";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back";

            counter = 120;
            this.acctNo = acctNo;

            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer.Stop();
                mainForm.GoToState(new DisplayMainMenuState(mainForm, language));
            }
        }

        public override State handleLeftPicBoxClick()
        {
            if (cashInserted)
            {
                amount = 0;
                theCashSlot.removeCash();
            }
            else
            {
                using (DepositAmount depositAmount = new DepositAmount())
                {
                    if (depositAmount.ShowDialog(mainForm) == DialogResult.OK)
                    {
                        amount = depositAmount.Amount;
                        theCashSlot.insertCash();
                    }
                }
            }

            cashInserted = !cashInserted;
            return this;
        }

        public override State handleRight1BTNClick()
        {
            bigDisplayLBL.Text = "Tabulating Cash...";
            timer.Stop();
            theCashSlot.tabulateCash();

            if (amount <= 0)
            {
                bigDisplayLBL.Text = "No notes detected, try again\nInsert cash into the cash slot\nOnly notes of SGD 10, 50, 100, 1000 are allowed";
                timer.Start();
                theCashSlot.withoutCash();
                cashInserted = false;
                return this;
            }
            else if (Math.Abs(amount % 1) > (double.Epsilon * 100))
            {
                return new RejectTabulatedCashState(mainForm, language, acctNo, "Only accept notes\nPlease remove cash");
            }
            else if (amount % 10 != 0)
            {
                return new RejectTabulatedCashState(mainForm, language, acctNo, "Only $10, $50, $100, $1000 are allowed\nPlease remove cash");
            }
            else
            {
                return new DisplayTabulatedCash(mainForm, language, acctNo, amount);
            }
        }

        public override State handleRight4BTNClick()
        {
            timer.Stop();
            theCashSlot.withoutCash();
            return new ChooseAcctToDepositState(mainForm, language);
        }
    }
}
