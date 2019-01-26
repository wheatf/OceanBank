using OceanBank.Codes.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class EnterAmtToWithdrawState : State
    {
        private string amountEnteredTxt;
        private string acctNo;

        public EnterAmtToWithdrawState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            this.acctNo = acctNo;

            bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nEnter amount to withdraw";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Ok"; right2BTN.Text = "Clear"; right3BTN.Text = ""; right4BTN.Text = "Back";

            amountEnteredTxt = "";
        }

        public override State handleKey1BTNClick()
        {
            State nextStep = processKey("1");
            return nextStep;
        }

        public override State handleKey2BTNClick()
        {
            State nextStep = processKey("2");
            return nextStep;
        }

        public override State handleKey3BTNClick()
        {
            State nextStep = processKey("3");
            return nextStep;
        }

        public override State handleKey4BTNClick()
        {
            State nextStep = processKey("4");
            return nextStep;
        }

        public override State handleKey5BTNClick()
        {
            State nextStep = processKey("5");
            return nextStep;
        }

        public override State handleKey6BTNClick()
        {
            State nextStep = processKey("6");
            return nextStep;
        }

        public override State handleKey7BTNClick()
        {
            State nextStep = processKey("7");
            return nextStep;
        }

        public override State handleKey8BTNClick()
        {
            State nextStep = processKey("8");
            return nextStep;
        }

        public override State handleKey9BTNClick()
        {
            State nextStep = processKey("9");
            return nextStep;
        }

        public override State handleKey0BTNClick()
        {
            State nextStep = processKey("0");
            return nextStep;
        }

        public override State handleRight1BTNClick()
        {
            State nextStep = new EnterAmtToWithdrawState(mainForm, language, acctNo);

            double withdrawAmt;
            Account withdrawFromAcct;

            withdrawFromAcct = theCard.getAcctUsingAcctNo(acctNo);
            //withdrawFromAcct.withdraw(withdrawAmt);

            // input is empty
            if (string.IsNullOrWhiteSpace(amountEnteredTxt))
            {
                bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nPlease enter an amount";
                amountEnteredTxt = "";
                smallDisplayLBL.Text = amountEnteredTxt;
            }
            //// input is not numeric
            //else if(!amountEnteredTxt.IsDouble())
            //{
            //    bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nOnly numeric values are allowed";
            //    amountEnteredTxt = "";
            //    smallDisplayLBL.Text = amountEnteredTxt;
            //}
            else
            {
                withdrawAmt = Convert.ToDouble(amountEnteredTxt);

                // input is less than or equals 0
                if(withdrawAmt <= 0)
                {
                    bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nPlease enter an amount larger than 0";
                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                // input is not in mutiples of 10
                else if (withdrawAmt % 10d != 0)
                {
                    bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nPlease enter in multiples of 10 or 100";
                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else if (withdrawAmt > withdrawFromAcct.getBalance())
                {
                    bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nAmount is larger than your balance\nSelect a smaller amount";
                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else
                {
                    withdrawFromAcct.withdraw(withdrawAmt);
                    nextStep = new TakeCashState(mainForm, language, acctNo);
                }
            }

            return nextStep;
        }

        public override State handleRight2BTNClick()
        {
            amountEnteredTxt = "";
            smallDisplayLBL.Text = amountEnteredTxt;
            return this;
        }

        public override State handleRight4BTNClick()
        {
            State nextStep = new ChooseAcctToWithdrawState(mainForm, language);
            return nextStep;
        }

        private State processKey(string k)
        {
            State nextStep = this;

            amountEnteredTxt += k;
            smallDisplayLBL.Text = amountEnteredTxt;

            return nextStep;
        }
    }
}
