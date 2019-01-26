using OceanBank.Codes.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class EnterAmtTransferFundsState : State
    {
        private string amountEnteredTxt;
        private string acctNoFrom;
        private string acctNoTo;

        public EnterAmtTransferFundsState(GUIforATM mainForm, string language, 
            string acctNoFrom,
            string acctNoTo) : 
            base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;
            this.acctNoTo = acctNoTo;

            bigDisplayLBL.Text = bigDisplayLBL.Text = "Please enter the amount to transfer";
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
            State nextStep = new EnterAmtTransferFundsState(mainForm, language, acctNoFrom, acctNoTo);

            double transferAmt;
            Account transferFromAcct;

            transferFromAcct = theCard.getAcctUsingAcctNo(acctNoFrom);

            // input is empty
            if (string.IsNullOrWhiteSpace(amountEnteredTxt))
            {
                bigDisplayLBL.Text = "Please enter an amount";
                amountEnteredTxt = "";
                smallDisplayLBL.Text = amountEnteredTxt;
            }
            //// input is not numeric
            //else if (!amountEnteredTxt.IsDouble())
            //{
            //    bigDisplayLBL.Text = "Only numeric values are allowed";
            //    amountEnteredTxt = "";
            //    smallDisplayLBL.Text = amountEnteredTxt;
            //}
            else
            {
                transferAmt = Convert.ToDouble(amountEnteredTxt);

                // input is less than or equals 0
                if (transferAmt <= 0)
                {
                    bigDisplayLBL.Text = "Please enter an amount larger than 0";
                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else if (transferAmt > transferFromAcct.getBalance())
                {
                    bigDisplayLBL.Text = "Amount is larger than " + acctNoFrom + "'s balance\nSelect a smaller amount";
                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else
                {
                    nextStep = new ConfirmAmountTransferState(mainForm, language,
                        acctNoFrom,
                        acctNoTo,
                        transferAmt);
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
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
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
