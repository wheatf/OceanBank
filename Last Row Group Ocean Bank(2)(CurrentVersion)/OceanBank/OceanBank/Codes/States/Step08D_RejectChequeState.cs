using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class RejectChequeState : State
    {
        public RejectChequeState(GUIforATM mainForm, string language) : base(mainForm, language)
        {
            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "请删除你的支票";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Sila buang cek anda";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "உங்கள் காசோலை நீக்கவும்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else
            {
                bigDisplayLBL.Text = "Please remove your cheque";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }

            theChequeSlot.showCheque();
        }

        public override State handleBottomPicBoxClick()
        {
            theChequeSlot.withoutCheque();
            return new DisplayMainMenuState(mainForm, language);
        }
    }
}
