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
            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "将检查插入检查槽";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "继续"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "背部";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Masukkan cek ke dalam slot cek";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Teruskan"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Kembali";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "காசோலை ஸ்லாட்டில் செருகவும்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "தொடர்ந்து"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "மீண்டும்";
            }
            else
            {
                bigDisplayLBL.Text = "Insert cheque into the cheque slot";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back";
            }

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
                if(language.ToUpper() == "CHINESE")
                    bigDisplayLBL.Text = "制表金额...";
                else if(language.ToUpper() == "MALAY")
                    bigDisplayLBL.Text = "Jumlah tabulasi...";
                else if(language.ToUpper() == "TAMIL")
                    bigDisplayLBL.Text = "தொடுக்கும் அளவு...";
                else
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
                if(language.ToUpper() == "CHINESE")
                    bigDisplayLBL.Text = "检查槽是空的\n请将支票插入支票槽";
                else if(language.ToUpper() == "MALAY")
                    bigDisplayLBL.Text = "Periksa slot kosong\nSila masukkan cek ke dalam slot cek";
                else if(language.ToUpper() == "TAMIL")
                    bigDisplayLBL.Text = "சரிபார்ப்பு காலியாக உள்ளது\nகாசோலை ஸ்லாட்டில் சரிபார்க்கவும்";
                else
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
