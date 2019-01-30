using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    class DisplayMainMenuState : State
    {

        public DisplayMainMenuState(GUIforATM mainForm, string language) : base(mainForm, language)
        {
            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "请选择交易";
                smallDisplayLBL.Text = "";
                left1BTN.Text = "检查存款余额"; left2BTN.Text = "提款"; left3BTN.Text = (theCard.getNumAccounts() > 1 ? "转移资金" : ""); left4BTN.Text = "存款现金";
                right1BTN.Text = "银行信息"; right2BTN.Text = "存款支票"; right3BTN.Text = ""; right4BTN.Text = "退出";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Sila pilih urus niaga anda";
                smallDisplayLBL.Text = "";
                left1BTN.Text = "Lihat Baki"; left2BTN.Text = "Mengeluarkan tunai"; left3BTN.Text = (theCard.getNumAccounts() > 1 ? "Dana Pemindahan" : ""); left4BTN.Text = "Deposit Tunai";
                right1BTN.Text = "Mengenai OceanBank"; right2BTN.Text = "Cek Deposit"; right3BTN.Text = ""; right4BTN.Text = "Keluar";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "உங்கள் பரிவர்த்தனைத் தேர்ந்தெடுக்கவும்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = "இருப்பு காண்க"; left2BTN.Text = "பணத்தை விலக்கு"; left3BTN.Text = (theCard.getNumAccounts() > 1 ? "பரிமாற்ற நிதிகள்" : ""); left4BTN.Text = "வைப்பு பண";
                right1BTN.Text = "பற்றி கடல்வங்கி"; right2BTN.Text = "வைப்பு காசோலை"; right3BTN.Text = ""; right4BTN.Text = "வெளியேறு";
            }
            else //ENGLISH
            {
                bigDisplayLBL.Text = "Please select your transaction";
                smallDisplayLBL.Text = "";
                left1BTN.Text = "View Balance"; left2BTN.Text = "Withdraw Cash"; left3BTN.Text = (theCard.getNumAccounts() > 1 ? "Transfer Funds" : ""); left4BTN.Text = "Deposit Cash";
                right1BTN.Text = "About OceanBank"; right2BTN.Text = "Deposit Cheque"; right3BTN.Text = ""; right4BTN.Text = "Exit";
            }
        }

        public override State handleLeft1BTNClick()
        {
            State nextStep = new ChooseAcctToViewBalanceState(mainForm, language);
            return nextStep;
        }

        public override State handleLeft2BTNClick()
        {
            State nextStep = new ChooseAcctToWithdrawState(mainForm, language);
            return nextStep;
        }

        public override State handleLeft3BTNClick()
        {
            // Can't transer funds if there is only one account
            if(theCard.getNumAccounts() > 1)
            {
                return new ChooseAcctToTransferFundsFromState(mainForm, language);
            }
            else
            {
                return base.handleLeft3BTNClick();
            }
        }

        public override State handleLeft4BTNClick()
        {
            return new ChooseAcctToDepositState(mainForm, language);
        }

        public override State handleRight1BTNClick()
        {
            State nextStep = new ViewAboutInfoState(mainForm, language);
            return nextStep;
        }

        public override State handleRight2BTNClick()
        {
            return new ChooseAcctToInsertChequeState(mainForm, language);
        }

        public override State handleRight4BTNClick()
        {
            State nextStep = new RemoveCardState(mainForm, language);
            return nextStep;
        }
    }
}
