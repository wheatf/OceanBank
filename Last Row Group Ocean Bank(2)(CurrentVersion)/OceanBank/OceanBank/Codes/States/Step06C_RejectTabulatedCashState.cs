using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class RejectTabulatedCashState : State
    {
        private string acctNo;

        public RejectTabulatedCashState(GUIforATM mainForm, string language, string acctNo, string error) : base(mainForm, language)
        {
            bigDisplayLBL.Text = error;
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";

            this.acctNo = acctNo;
            theCashSlot.ejectCash();
        }

        public override State handleLeftPicBoxClick()
        {
            theCashSlot.removeCash();
            return new InsertCashDepositState(mainForm, language, acctNo);
        }
    }
}
