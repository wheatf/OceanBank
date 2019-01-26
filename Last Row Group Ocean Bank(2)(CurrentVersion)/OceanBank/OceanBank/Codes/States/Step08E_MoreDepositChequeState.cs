using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class MoreDepositChequeState : State
    {
        private string acctNo;

        public MoreDepositChequeState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            this.acctNo = acctNo;
            Account account = theCard.getAcctUsingAcctNo(acctNo);

            bigDisplayLBL.Text = account.getAcctNo() + "'s new balance: " + string.Format("{0:C}", account.getBalance()) + "\nMake another transaction ?";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Ok"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
        }

        public override State handleRight1BTNClick()
        {
            return new InsertChequeState(mainForm, language, acctNo);
        }

        public override State handleRight4BTNClick()
        {
            return new DisplayMainMenuState(mainForm, language);
        }
    }
}
