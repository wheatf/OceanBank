using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ViewAboutInfoState : State
    {
        public ViewAboutInfoState(GUIforATM mainForm, string language) : base(mainForm, language)
        {

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "Last Row Group 海洋银行 是新加坡的一家大型消费者银行公司，拥有遍布全岛的500多台ATM机网络";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Last Row Group Ocean Bank adalah sebuah syarikat perbankan pengguna yang besar di Singapura dan mempunyai rangkaian lebih dari 500 mesin ATM yang terletak di seluruh pulau";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "Last Row Group கடல் வங்கி சிங்கப்பூரில் ஒரு பெரிய நுகர்வோர் வங்கி நிறுவனம் மற்றும் தீவு முழுவதும் அமைந்துள்ள 500 க்கும் மேற்பட்ட ஏ.டி.எம் இயந்திரங்களைக் கொண்டுள்ளது";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }
            else
            {
                bigDisplayLBL.Text = "Last Row Group Ocean Bank is a large consumer banking company in Singapore and have a network of more than 500 ATMs machines located island-wide";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }
        }

        public override State handleRight4BTNClick()
        {
            State nextStep = new DisplayMainMenuState(mainForm, language);
            return nextStep;
        }
    }
}
