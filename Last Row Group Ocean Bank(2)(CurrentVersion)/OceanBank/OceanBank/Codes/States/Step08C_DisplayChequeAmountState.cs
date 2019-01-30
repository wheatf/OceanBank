using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class DisplayChequeAmountState : State
    {
        private string acctNo;
        private double amount;

        public DisplayChequeAmountState(GUIforATM mainForm, string language, string acctNo, double amount) : base(mainForm, language)
        {
            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "从支票存入的金额: " + string.Format("{0:C}", amount) + "\n继续存款?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "继续"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "取消";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Jumlah deposit dari cek: " + string.Format("{0:C}", amount) + "\nTeruskan dengan deposit?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Teruskan"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Batalkan";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "காசோலை இருந்து வைப்பு தொகை: " + string.Format("{0:C}", amount) + "\nவைப்புடன் தொடரவா?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "தொடர்ந்து"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "ரத்து";
            }
            else
            {
                bigDisplayLBL.Text = "Amount to deposit from cheque: " + string.Format("{0:C}", amount) + "\nContinue with deposit?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Cancel";
            }

            this.acctNo = acctNo;
            this.amount = amount;
        }

        public override State handleRight1BTNClick()
        {
            theCard.getAcctUsingAcctNo(acctNo).deposit(amount);
            return new MoreDepositChequeState(mainForm, language, acctNo);
        }

        public override State handleRight4BTNClick()
        {
            return new RejectChequeState(mainForm, language);
        }
    }
}
