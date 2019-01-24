using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class MoreWithdrawalState : State
    {
        Account account;

        public MoreWithdrawalState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            account = theCard.getAcctUsingAcctNo(acctNo);

            bigDisplayLBL.Text = "Make another transaction?";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Ok"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
        }

        public override State handleRight1BTNClick()
        {
            return new ChooseAcctToWithdrawState(mainForm, language);
        }

        public override State handleRight4BTNClick()
        {
            return new DisplayMainMenuState(mainForm, language);
        }
    }
}
