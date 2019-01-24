using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ViewBalanceState : State
    {
        public ViewBalanceState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            bigDisplayLBL.Text = "Balance for account " + acctNo + "\n" + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNo).getBalance());
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";

        }

        public override State handleRight4BTNClick()
        {
            State nextStep = new DisplayMainMenuState(mainForm, language);
            return nextStep;
        }
    }
}
