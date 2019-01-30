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

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "请确认所选帐户\n从: " + acctNoFrom + "\n至:" + acctNoTo;
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "确认"; right2BTN.Text = "背部"; right3BTN.Text = ""; right4BTN.Text = "返回主菜单";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Sila sahkan akaun yang dipilih\nDari: " + acctNoFrom + "\nUntuk:" + acctNoTo;
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Sahkan"; right2BTN.Text = "Kembali"; right3BTN.Text = ""; right4BTN.Text = "Kembali ke Menu Utama";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "தேர்ந்தெடுத்த கணக்குகளை உறுதிப்படுத்துக\nஇருந்து: " + acctNoFrom + "\nசெய்ய:" + acctNoTo;
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "உறுதிப்படுத்தவும்"; right2BTN.Text = "மீண்டும்"; right3BTN.Text = ""; right4BTN.Text = "முதன்மை பட்டிக்கு திரும்புக";
            }
            else
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Please confirm the selected accounts\nFrom: " + acctNoFrom + "\nTo:" + acctNoTo;
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Confirm"; right2BTN.Text = "Back"; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }
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
