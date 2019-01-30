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
            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "账户余额 " + acctNo + "\n" + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNo).getBalance());
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "返回主菜单";
            }
            else if (language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Baki untuk akaun " + acctNo + "\n" + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNo).getBalance());
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Kembali ke Menu Utama";
            }
            else if (language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "கணக்கிற்கான இருப்பு " + acctNo + "\n" + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNo).getBalance());
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "முதன்மை பட்டிக்கு திரும்புக";
            }
            else
            {
                bigDisplayLBL.Text = "Balance for account " + acctNo + "\n" + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNo).getBalance());
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
