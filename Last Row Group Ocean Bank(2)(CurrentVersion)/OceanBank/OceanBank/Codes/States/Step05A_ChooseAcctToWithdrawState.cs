using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ChooseAcctToWithdrawState : State
    {
        public ChooseAcctToWithdrawState(GUIforATM mainForm, string language) : base(mainForm, language)
        {

            bigDisplayLBL.Text = "Please select account to withdraw from";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";

            if (theCard.getNumAccounts() >= 1)
                left1BTN.Text = theCard.getAcctAtIndex(0).getAcctNo();

            if (theCard.getNumAccounts() >= 2)
                left2BTN.Text = theCard.getAcctAtIndex(1).getAcctNo();

            if (theCard.getNumAccounts() >= 3)
                left3BTN.Text = theCard.getAcctAtIndex(2).getAcctNo();

            if (theCard.getNumAccounts() >= 4)
                left4BTN.Text = theCard.getAcctAtIndex(3).getAcctNo();

            if (theCard.getNumAccounts() == 5) //Max 5 accounts per card
                right1BTN.Text = theCard.getAcctAtIndex(4).getAcctNo();

        }

        public override State handleLeft1BTNClick()
        {
            State nextStep = this;
            if (left1BTN.Text != "")
            {
                nextStep = new EnterAmtToWithdrawState(mainForm, language, left1BTN.Text);
            }
            return nextStep;
        }

        public override State handleLeft2BTNClick()
        {
            State nextStep = this;
            if (left2BTN.Text != "")
            {
                nextStep = new EnterAmtToWithdrawState(mainForm, language, left2BTN.Text);
            }
            return nextStep;
        }


        public override State handleLeft3BTNClick()
        {
            State nextStep = this;
            if (left3BTN.Text != "")
            {
                nextStep = new EnterAmtToWithdrawState(mainForm, language, left3BTN.Text);
            }
            return nextStep;
        }

        public override State handleLeft4BTNClick()
        {
            State nextStep = this;
            if(left4BTN.Text != "")
            {
                nextStep = new EnterAmtToWithdrawState(mainForm, language, left4BTN.Text);
            }
            return nextStep;
        }

        public override State handleRight1BTNClick()
        {
            State nextStep = this;
            if(right1BTN.Text != "")
            {
                nextStep = new EnterAmtToWithdrawState(mainForm, language, right1BTN.Text);
            }
            return nextStep;
        }

        public override State handleRight4BTNClick()
        {
            State nextStep = new DisplayMainMenuState(mainForm, language);
            return nextStep;
        }
    }
}
