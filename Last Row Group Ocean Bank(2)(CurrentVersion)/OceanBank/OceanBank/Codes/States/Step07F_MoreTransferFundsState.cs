using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class MoreTransferFundsState : State
    {
        private string acctNoFrom;
        private string acctNoTo;

        public MoreTransferFundsState(GUIforATM mainForm, string language, 
            string acctNoFrom,
            string acctNoTo) : base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;
            this.acctNoTo = acctNoTo;

            bigDisplayLBL.Text = bigDisplayLBL.Text =
                acctNoFrom + "'s new balance: " + string.Format("{0:0.00}", theCard.getAcctUsingAcctNo(acctNoFrom).getBalance()) + "\n" +
                acctNoTo + "'s new balance: " + string.Format("{0:0.00}", theCard.getAcctUsingAcctNo(acctNoTo).getBalance());
            bigDisplayLBL.Text = "Make another transaction?";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Ok"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
        }

        public override State handleRight1BTNClick()
        {
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
        }

        public override State handleRight4BTNClick()
        {
            return new DisplayMainMenuState(mainForm, language);
        }
    }
}
