using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ChooseAcctToTransferFundsToState : State
    {
        private string acctNoFrom;

        public ChooseAcctToTransferFundsToState(GUIforATM mainForm, string language, string acctNoFrom) : base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "请选择一个帐户将资金转入";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "背部";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Sila pilih akaun untuk memindahkan dana anda";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Kembali";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "உங்கள் நிதிகளை மாற்றுவதற்கு ஒரு கணக்கைத் தேர்ந்தெடுக்கவும்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "மீண்டும்";
            }
            else
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Please select an account to transfer your funds to";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back";
            }

            string acctNo;

            if (theCard.getNumAccounts() >= 1)
            {
                // don't allow user to send fund to same account
                acctNo = theCard.getAcctAtIndex(0).getAcctNo();
                left1BTN.Text = (acctNo != acctNoFrom ? acctNo : "");
            }

            if (theCard.getNumAccounts() >= 2)
            {
                acctNo = theCard.getAcctAtIndex(1).getAcctNo();
                left2BTN.Text = (acctNo != acctNoFrom ? acctNo : "");
            }

            if (theCard.getNumAccounts() >= 3)
            {
                acctNo = theCard.getAcctAtIndex(2).getAcctNo();
                left3BTN.Text = (acctNo != acctNoFrom ? acctNo : "");
            }

            if (theCard.getNumAccounts() >= 4)
            {
                acctNo = theCard.getAcctAtIndex(3).getAcctNo();
                left4BTN.Text = (acctNo != acctNoFrom ? acctNo : "");
            }

            if (theCard.getNumAccounts() == 5) //Max 5 account per card
            {
                acctNo = theCard.getAcctAtIndex(4).getAcctNo();
                right1BTN.Text = (acctNo != acctNoFrom ? acctNo : "");
            }
        }

        public override State handleLeft1BTNClick()
        {
            State nextStep = this;
            if (left1BTN.Text != "")
            {
                nextStep = new ConfirmSelectedAcctTransferFundsState(mainForm, language, acctNoFrom, left1BTN.Text);
            }
            return nextStep;
        }

        public override State handleLeft2BTNClick()
        {
            State nextStep = this;
            if (left2BTN.Text != "")
            {
                nextStep = new ConfirmSelectedAcctTransferFundsState(mainForm, language, acctNoFrom, left2BTN.Text);
            }
            return nextStep;
        }


        public override State handleLeft3BTNClick()
        {
            State nextStep = this;
            if (left3BTN.Text != "")
            {
                nextStep = new ConfirmSelectedAcctTransferFundsState(mainForm, language, acctNoFrom, left3BTN.Text);
            }
            return nextStep;
        }

        public override State handleLeft4BTNClick()
        {
            State nextStep = this;
            if (left4BTN.Text != "")
            {
                nextStep = new ConfirmSelectedAcctTransferFundsState(mainForm, language, acctNoFrom, left4BTN.Text);
            }

            return nextStep;
        }

        public override State handleRight1BTNClick()
        {
            State nextStep = this;
            if (right1BTN.Text != "")
            {
                nextStep = new ConfirmSelectedAcctTransferFundsState(mainForm, language, acctNoFrom, right1BTN.Text);
            }
            return nextStep;
        }

        public override State handleRight4BTNClick()
        {
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
        }
    }
}
