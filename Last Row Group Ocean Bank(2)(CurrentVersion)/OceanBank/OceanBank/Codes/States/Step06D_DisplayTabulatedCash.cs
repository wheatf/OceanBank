using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class DisplayTabulatedCash : State
    {
        private string acctNo;
        private double deposit;

        public DisplayTabulatedCash(GUIforATM mainForm, string language, string acctNo, double deposit) : base(mainForm, language)
        {
            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "存入的现金总额: " + string.Format("{0:C}", deposit) + "\n继续存款?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "继续"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "取消";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Jumlah wang tunai yang didepositkan: " + string.Format("{0:C}", deposit) + "\nTeruskan dengan deposit?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Teruskan"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Batalkan";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "மொத்த தொகையை டெபாசிட் செய்தார்: " + string.Format("{0:C}", deposit) + "\nவைப்புடன் தொடரவா?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "தொடர்ந்து"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "ரத்து";
            }
            else
            {
                bigDisplayLBL.Text = "Total amount of cash deposited: " + string.Format("{0:C}", deposit) + "\nContinue with deposit?";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Cancel";
            }

            this.acctNo = acctNo;
            this.deposit = deposit;
        }

        public override State handleRight1BTNClick()
        {
            theCard.getAcctUsingAcctNo(acctNo).deposit(deposit);
            return new MoreDepositState(mainForm, language, acctNo);
        }

        public override State handleRight4BTNClick()
        {
            return new RejectTabulatedCashState(mainForm, language, acctNo, "Please remove cash");
        }
    }
}
