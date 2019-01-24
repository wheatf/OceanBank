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
                left1BTN.Text = "检查存款余额"; left2BTN.Text = "提款"; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "银行信息"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "退出";
            }
            else //ENGLISH
            {
                bigDisplayLBL.Text = "Please select your transaction";
                smallDisplayLBL.Text = "";
                left1BTN.Text = "View Balance"; left2BTN.Text = "Withdraw"; left3BTN.Text = (theCard.getNumAccounts() > 1 ? "Transfer Funds" : ""); left4BTN.Text = "";
                right1BTN.Text = "About OceanBank"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Exit";
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

        public override State handleRight1BTNClick()
        {
            State nextStep = new ViewAboutInfoState(mainForm, language);
            return nextStep;
        }

        public override State handleRight4BTNClick()
        {
            State nextStep = new RemoveCardState(mainForm, language);
            return nextStep;
        }
    }
}
