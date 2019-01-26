using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class DisplayTabulatedCash : State
    {
        private string acctNo;
        private double deposit;

        public DisplayTabulatedCash(GUIforATM mainForm, string language, string acctNo, double deposit) : base(mainForm, language)
        {
            bigDisplayLBL.Text = "Total amount of cash deposited: " + string.Format("{0:C}", deposit) + "\nContinue with deposit?";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Cancel";

            this.acctNo = acctNo;
            this.deposit = deposit;
        }

        public override State handleRight1BTNClick()
        {
            theCard.getAcctUsingAcctNo(acctNo).deposit(deposit);
            return new MoreDepositState(mainForm, language, acctNo);
        }

        public override State handleRight4BTNClick()
        {
            return new RejectTabulatedCashState(mainForm, language, acctNo, "Please remove cash");
        }
    }
}
