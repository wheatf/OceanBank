using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class DisplayChequeAmountState : State
    {
        private string acctNo;
        private double amount;

        public DisplayChequeAmountState(GUIforATM mainForm, string language, string acctNo, double amount) : base(mainForm, language)
        {
            bigDisplayLBL.Text = "Amount to deposit from cheque: " + string.Format("{0:C}", amount) + "\nContinue with deposit?";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Cancel";

            this.acctNo = acctNo;
            this.amount = amount;
        }

        public override State handleRight1BTNClick()
        {
            theCard.getAcctUsingAcctNo(acctNo).deposit(amount);
            return new MoreDepositChequeState(mainForm, language, acctNo);
        }

        public override State handleRight4BTNClick()
        {
            return new RejectChequeState(mainForm, language);
        }
    }
}
