using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class MoreDepositState : State
    {
        private string acctNo;

        public MoreDepositState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            this.acctNo = acctNo;
            Account account = theCard.getAcctUsingAcctNo(acctNo);

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = account.getAcctNo() + "'s 新的平衡: " + string.Format("{0:C}", account.getBalance()) + "\n再做一次交易?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "好"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "返回主菜单";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = account.getAcctNo() + "'s keseimbangan baru: " + string.Format("{0:C}", account.getBalance()) + "\nBuat transaksi lain?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Kembali ke Menu Utama";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = account.getAcctNo() + "'s புதிய சமநிலையை: " + string.Format("{0:C}", account.getBalance()) + "\nமற்றொரு பரிவர்த்தனை செய்யவா?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "சரி"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "முதன்மை பட்டிக்கு திரும்புக";
            }
            else
            {
                bigDisplayLBL.Text = account.getAcctNo() + "'s new balance: " + string.Format("{0:C}", account.getBalance()) + "\nMake another transaction?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }
        }

        public override State handleRight1BTNClick()
        {
            return new InsertCashDepositState(mainForm, language, acctNo);
        }

        public override State handleRight4BTNClick()
        {
            return new DisplayMainMenuState(mainForm, language);
        }
    }
}
