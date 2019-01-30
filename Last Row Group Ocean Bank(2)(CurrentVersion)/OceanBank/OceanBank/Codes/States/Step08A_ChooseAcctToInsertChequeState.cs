using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ChooseAcctToInsertChequeState : State
    {
        public ChooseAcctToInsertChequeState(GUIforATM mainForm, string language) : base(mainForm, language)
        {
            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "请选择一个帐户来存入支票";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "返回主菜单";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Sila pilih akaun untuk mendepositkan cek anda";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Kembali ke Menu Utama";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "உங்கள் காசோலை வைப்பதற்கு ஒரு கணக்கைத் தேர்ந்தெடுக்கவும்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "முதன்மை பட்டிக்கு திரும்புக";
            }
            else
            {
                bigDisplayLBL.Text = "Please select an account to deposit your cheque to";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }

            if (theCard.getNumAccounts() >= 1)
                left1BTN.Text = theCard.getAcctAtIndex(0).getAcctNo();

            if (theCard.getNumAccounts() >= 2)
                left2BTN.Text = theCard.getAcctAtIndex(1).getAcctNo();

            if (theCard.getNumAccounts() >= 3)
                left3BTN.Text = theCard.getAcctAtIndex(2).getAcctNo();

            if (theCard.getNumAccounts() >= 4)
                left4BTN.Text = theCard.getAcctAtIndex(3).getAcctNo();

            if (theCard.getNumAccounts() == 5) //Max 5 account per card
                right1BTN.Text = theCard.getAcctAtIndex(4).getAcctNo();
        }

        public override State handleLeft1BTNClick()
        {
            State nextStep = this;
            if (left1BTN.Text != "")
            {
                nextStep = new InsertChequeState(mainForm, language, left1BTN.Text);
            }
            return nextStep;
        }

        public override State handleLeft2BTNClick()
        {
            State nextStep = this;
            if (left2BTN.Text != "")
            {
                nextStep = new InsertChequeState(mainForm, language, left2BTN.Text);
            }
            return nextStep;
        }


        public override State handleLeft3BTNClick()
        {
            State nextStep = this;
            if (left3BTN.Text != "")
            {
                nextStep = new InsertChequeState(mainForm, language, left3BTN.Text);
            }
            return nextStep;
        }

        public override State handleLeft4BTNClick()
        {
            State nextStep = this;
            if (left4BTN.Text != "")
            {
                nextStep = new InsertChequeState(mainForm, language, left4BTN.Text);
            }

            return nextStep;
        }

        public override State handleRight1BTNClick()
        {
            State nextStep = this;
            if (right1BTN.Text != "")
            {
                nextStep = new InsertChequeState(mainForm, language, right1BTN.Text);
            }
            return nextStep;
        }

        public override State handleRight4BTNClick()
        {
            return new DisplayMainMenuState(mainForm, language);
        }
    }
}
