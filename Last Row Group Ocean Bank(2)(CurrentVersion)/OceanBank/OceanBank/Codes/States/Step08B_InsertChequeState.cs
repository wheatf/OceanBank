using OceanBank.Codes.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class InsertChequeState : State
    {
        private string acctNo;
        private bool chequeInserted = false;

        public InsertChequeState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            bigDisplayLBL.Text = "Insert cheque into the cheque slot";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back";

            this.acctNo = acctNo;
        }

        public override State handleBottomPicBoxClick()
        {
            if (chequeInserted)
            {
                theChequeSlot.withoutCheque();
            }
            else
            {
                theChequeSlot.insertCheque();
            }

            chequeInserted = !chequeInserted;
            return this;
        }

        public override State handleRight1BTNClick()
        {
            if (chequeInserted)
            {
                bigDisplayLBL.Text = "Tabulating amount...";
                theChequeSlot.tabulateCheque();

                using(DepositAmount depositAmount = new DepositAmount())
                {
                    if(depositAmount.ShowDialog(mainForm) == System.Windows.Forms.DialogResult.OK)
                    {
                        return new DisplayChequeAmountState(mainForm, language, acctNo, depositAmount.Amount);
                    }
                    else
                    {
                        return new DisplayMainMenuState(mainForm, language);
                    }
                }
            }
            else
            {
                bigDisplayLBL.Text = "Cheque slot is empty\nPlease insert cheque into the cheque slot";
                return this;
            }
        }

        public override State handleRight4BTNClick()
        {
            return new ChooseAcctToInsertChequeState(mainForm, language);
        }
    }
}
