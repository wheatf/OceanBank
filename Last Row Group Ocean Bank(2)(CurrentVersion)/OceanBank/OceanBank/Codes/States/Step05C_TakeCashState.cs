using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class TakeCashState : State
    {

        private string acctNo;

        public TakeCashState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            Account withdrawFromAcct;
            this.acctNo = acctNo;

            withdrawFromAcct = theCard.getAcctUsingAcctNo(acctNo);

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "剩余的余额 " + acctNo + "\n" + string.Format("{0:C}", withdrawFromAcct.getBalance()) + "\n请带现金";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Baki baki dalam " + acctNo + "\n" + string.Format("{0:C}", withdrawFromAcct.getBalance()) + "\nSila ambil wang tunai";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "மீதமுள்ள சமநிலை " + acctNo + "\n" + string.Format("{0:C}", withdrawFromAcct.getBalance()) + "\nபணத்தை எடுத்துக் கொள்ளுங்கள்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else
            {
                bigDisplayLBL.Text = "Remaining balance in " + acctNo + "\n" + string.Format("{0:C}", withdrawFromAcct.getBalance()) + "\nPlease take cash";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }

            theCashSlot.ejectCash();

        }

        public override State handleLeftPicBoxClick()
        {
            theCashSlot.removeCash();
            State nextStep = new MoreWithdrawalState(mainForm, language, acctNo);
            return nextStep;
        }
    }
}
