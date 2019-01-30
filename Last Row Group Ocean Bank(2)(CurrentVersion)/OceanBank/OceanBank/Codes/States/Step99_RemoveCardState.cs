using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    class RemoveCardState : State
    {
        public RemoveCardState(GUIforATM mainForm, string language) : base(mainForm, language)
        {
            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "感谢您使用海洋银行服务\n请取回银行卡";
                smallDisplayLBL.Text = "";
                theCardReader.ejectCard();
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Terima kasih kerana menggunakan Ocean Bank\nSila alih keluar kad";
                smallDisplayLBL.Text = "";
                theCardReader.ejectCard();
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "பயன்படுத்துவதற்கு நன்றி கடல் வங்கி\nகார்டை அகற்றவும்";
                smallDisplayLBL.Text = "";
                theCardReader.ejectCard();
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else //ENGLISH
            {
                bigDisplayLBL.Text = "Thank you for using Ocean Bank\nPlease remove card";
                smallDisplayLBL.Text = "";
                theCardReader.ejectCard();
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
        }


        public override State handleRightPicBoxClick()
        {
            State nextStep;

            theCardReader.withoutCard();
            nextStep = new WaitForBankCardState(mainForm, language);
            return nextStep;
        }
    }
}
