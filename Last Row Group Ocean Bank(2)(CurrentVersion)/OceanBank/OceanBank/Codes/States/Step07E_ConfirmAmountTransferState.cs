using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ConfirmAmountTransferState : State
    {
        private string acctNoFrom;
        private string acctNoTo;
        private double amount;

        public ConfirmAmountTransferState(GUIforATM mainForm, string language,
            string acctNoFrom,
            string acctNoTo,
            double amount) : base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;
            this.acctNoTo = acctNoTo;
            this.amount = amount;

            bigDisplayLBL.Text = bigDisplayLBL.Text = "Please confirm the details\nFrom: " + acctNoFrom + "\nTo: " + acctNoTo + "\nAmount: " + string.Format("{0:C}", amount);
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Ok"; right2BTN.Text = "Adjust Amount"; right3BTN.Text = ""; right4BTN.Text = "Back";
        }

        public override State handleRight1BTNClick()
        {
            theCard.getAcctUsingAcctNo(acctNoFrom).withdraw(amount);
            theCard.getAcctUsingAcctNo(acctNoTo).deposit(amount);
            return new MoreTransferFundsState(mainForm, language, acctNoFrom, acctNoTo);
        }

        public override State handleRight2BTNClick()
        {
            return new EnterAmtTransferFundsState(mainForm, language, acctNoFrom, acctNoTo);
        }

        public override State handleRight4BTNClick()
        {
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
        }
    }
}
