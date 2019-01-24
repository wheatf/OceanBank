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

            bigDisplayLBL.Text = "Remaining balance in " + acctNo + "\n" + string.Format("{0:C}" ,withdrawFromAcct.getBalance()) + "\nPlease take cash";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";

            theCashDispenser.ejectCash();

        }

        public override State handleLeftPicBoxClick()
        {
            theCashDispenser.removeCash();
            State nextStep = new MoreWithdrawalState(mainForm, language, acctNo);
            return nextStep;
        }
    }
}
