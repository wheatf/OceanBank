using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ConfirmAmountTransferState : State
    {
        private string acctNoFrom;
        private string acctNoTo;
        private double amount;

        public ConfirmAmountTransferState(GUIforATM mainForm, string language,
            string acctNoFrom,
            string acctNoTo,
            double amount) : base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;
            this.acctNoTo = acctNoTo;
            this.amount = amount;

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "请确认详细信息\n从: " + acctNoFrom + "\n至: " + acctNoTo + "\n量: " + string.Format("{0:C}", amount);
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "好"; right2BTN.Text = "调整金额"; right3BTN.Text = ""; right4BTN.Text = "背部";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Sila sahkan butiran\nDari: " + acctNoFrom + "\nUntuk: " + acctNoTo + "\nJumlah: " + string.Format("{0:C}", amount);
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = "Laraskan Amaun"; right3BTN.Text = ""; right4BTN.Text = "Kembali";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "விவரங்களை உறுதிப்படுத்துக\nஇருந்து: " + acctNoFrom + "\nசெய்ய: " + acctNoTo + "\nதொகை: " + string.Format("{0:C}", amount);
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "சரி"; right2BTN.Text = "தொகை சரிசெய்யவும்"; right3BTN.Text = ""; right4BTN.Text = "மீண்டும்";
            }
            else
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Please confirm the details\nFrom: " + acctNoFrom + "\nTo: " + acctNoTo + "\nAmount: " + string.Format("{0:C}", amount);
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = "Adjust Amount"; right3BTN.Text = ""; right4BTN.Text = "Back";
            }
        }

        public override State handleRight1BTNClick()
        {
            theCard.getAcctUsingAcctNo(acctNoFrom).withdraw(amount);
            theCard.getAcctUsingAcctNo(acctNoTo).deposit(amount);
            return new MoreTransferFundsState(mainForm, language, acctNoFrom, acctNoTo);
        }

        public override State handleRight2BTNClick()
        {
            return new EnterAmtTransferFundsState(mainForm, language, acctNoFrom, acctNoTo);
        }

        public override State handleRight4BTNClick()
        {
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
        }
    }
}
