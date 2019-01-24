using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ConfirmSelectedAcctTransferFundsState : State
    {
        private string acctNoFrom;
        private string acctNoTo;

        public ConfirmSelectedAcctTransferFundsState(GUIforATM mainForm, string language, 
            string acctNoFrom,
            string acctNoTo) 
            : base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;
            this.acctNoTo = acctNoTo;

            bigDisplayLBL.Text = bigDisplayLBL.Text = "Please confirm the selected accounts\nFrom: " + acctNoFrom + "\nTo:" + acctNoTo;
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Confirm"; right2BTN.Text = "Back"; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
        }

        public override State handleRight1BTNClick()
        {
            return new EnterAmtTransferFundsState(mainForm, language, acctNoFrom, acctNoTo);
        }

        public override State handleRight2BTNClick()
        {
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
        }
    }
}
