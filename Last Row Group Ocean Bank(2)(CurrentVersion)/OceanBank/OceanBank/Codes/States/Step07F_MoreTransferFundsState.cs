using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class MoreTransferFundsState : State
    {
        private string acctNoFrom;
        private string acctNoTo;

        public MoreTransferFundsState(GUIforATM mainForm, string language, 
            string acctNoFrom,
            string acctNoTo) : base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;
            this.acctNoTo = acctNoTo;

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text =
                acctNoFrom + "'s 新的平衡: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoFrom).getBalance()) + "\n" +
                acctNoTo + "'s 新的平衡: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoTo).getBalance());
                bigDisplayLBL.Text += "\n再做一次交易?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "好"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "返回主菜单";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text =
                acctNoFrom + "'s keseimbangan baru: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoFrom).getBalance()) + "\n" +
                acctNoTo + "'s keseimbangan baru: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoTo).getBalance());
                bigDisplayLBL.Text += "\nBuat transaksi lain?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Kembali ke Menu Utama";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text =
                acctNoFrom + "'s புதிய சமநிலையை: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoFrom).getBalance()) + "\n" +
                acctNoTo + "'s புதிய சமநிலையை: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoTo).getBalance());
                bigDisplayLBL.Text += "\nமற்றொரு பரிவர்த்தனை செய்யவா?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "சரி"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "முதன்மை பட்டிக்கு திரும்புக";
            }
            else
            {
                bigDisplayLBL.Text =
                acctNoFrom + "'s new balance: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoFrom).getBalance()) + "\n" +
                acctNoTo + "'s new balance: " + string.Format("{0:C}", theCard.getAcctUsingAcctNo(acctNoTo).getBalance());
                bigDisplayLBL.Text += "\nMake another transaction?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";
            }
        }

        public override State handleRight1BTNClick()
        {
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
        }

        public override State handleRight4BTNClick()
        {
            return new DisplayMainMenuState(mainForm, language);
        }
    }
}
