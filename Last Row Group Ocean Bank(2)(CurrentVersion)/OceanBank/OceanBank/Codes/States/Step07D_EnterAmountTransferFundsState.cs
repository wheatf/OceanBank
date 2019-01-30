using OceanBank.Codes.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class EnterAmtTransferFundsState : State
    {
        private string amountEnteredTxt;
        private string acctNoFrom;
        private string acctNoTo;

        public EnterAmtTransferFundsState(GUIforATM mainForm, string language, 
            string acctNoFrom,
            string acctNoTo) : 
            base(mainForm, language)
        {
            this.acctNoFrom = acctNoFrom;
            this.acctNoTo = acctNoTo;

            if(language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "请输入要转帐的金额";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "好"; right2BTN.Text = "明确"; right3BTN.Text = ""; right4BTN.Text = "背部";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Sila masukkan jumlah untuk dipindahkan";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = "Jelas"; right3BTN.Text = ""; right4BTN.Text = "Kembali";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "இடமாற்றம் செய்ய அளவு உள்ளிடவும்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "சரி"; right2BTN.Text = "தெளிவு"; right3BTN.Text = ""; right4BTN.Text = "மீண்டும்";
            }
            else
            {
                bigDisplayLBL.Text = bigDisplayLBL.Text = "Please enter the amount to transfer";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = "Clear"; right3BTN.Text = ""; right4BTN.Text = "Back";
            }

            amountEnteredTxt = "";
        }

        public override State handleKey1BTNClick()
        {
            State nextStep = processKey("1");
            return nextStep;
        }

        public override State handleKey2BTNClick()
        {
            State nextStep = processKey("2");
            return nextStep;
        }

        public override State handleKey3BTNClick()
        {
            State nextStep = processKey("3");
            return nextStep;
        }

        public override State handleKey4BTNClick()
        {
            State nextStep = processKey("4");
            return nextStep;
        }

        public override State handleKey5BTNClick()
        {
            State nextStep = processKey("5");
            return nextStep;
        }

        public override State handleKey6BTNClick()
        {
            State nextStep = processKey("6");
            return nextStep;
        }

        public override State handleKey7BTNClick()
        {
            State nextStep = processKey("7");
            return nextStep;
        }

        public override State handleKey8BTNClick()
        {
            State nextStep = processKey("8");
            return nextStep;
        }

        public override State handleKey9BTNClick()
        {
            State nextStep = processKey("9");
            return nextStep;
        }

        public override State handleKey0BTNClick()
        {
            State nextStep = processKey("0");
            return nextStep;
        }

        public override State handleRight1BTNClick()
        {
            State nextStep = new EnterAmtTransferFundsState(mainForm, language, acctNoFrom, acctNoTo);

            double transferAmt;
            Account transferFromAcct;

            transferFromAcct = theCard.getAcctUsingAcctNo(acctNoFrom);

            // input is empty
            if (string.IsNullOrWhiteSpace(amountEnteredTxt))
            {
                if(language.ToUpper() == "CHINESE")
                    bigDisplayLBL.Text = "请输入金额";
                else if(language.ToUpper() == "MALAY")
                    bigDisplayLBL.Text = "Sila masukkan amaun";
                else if(language.ToUpper() == "TAMIL")
                    bigDisplayLBL.Text = "தயவுசெய்து ஒரு அளவு உள்ளிடவும்";
                else
                    bigDisplayLBL.Text = "Please enter an amount";

                amountEnteredTxt = "";
                smallDisplayLBL.Text = amountEnteredTxt;
            }
            //// input is not numeric
            //else if (!amountEnteredTxt.IsDouble())
            //{
            //    bigDisplayLBL.Text = "Only numeric values are allowed";
            //    amountEnteredTxt = "";
            //    smallDisplayLBL.Text = amountEnteredTxt;
            //}
            else
            {
                transferAmt = Convert.ToDouble(amountEnteredTxt);

                // input is less than or equals 0
                if (transferAmt <= 0)
                {
                    if(language.ToUpper() == "CHINESE")
                        bigDisplayLBL.Text = "请输入大于0的金额";
                    else if(language.ToUpper() == "MALAY")
                        bigDisplayLBL.Text = "Sila masukkan jumlah yang lebih besar daripada 0";
                    else if(language.ToUpper() == "TAMIL")
                        bigDisplayLBL.Text = "0 ஐ விட பெரிய அளவு உள்ளிடவும்";
                    else
                        bigDisplayLBL.Text = "Please enter an amount larger than 0";

                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else if (transferAmt > transferFromAcct.getBalance())
                {
                    if (language.ToUpper() == "CHINESE")
                        bigDisplayLBL.Text = "金额大于 " + acctNoFrom + "'s 平衡\n选择较小的金额";
                    else if (language.ToUpper() == "MALAY")
                        bigDisplayLBL.Text = "Jumlahnya lebih besar daripada " + acctNoFrom + "'s Seimbang\nPilih jumlah yang lebih kecil";
                    else if (language.ToUpper() == "TAMIL")
                        bigDisplayLBL.Text = "தொகை அதிகமாக உள்ளது " + acctNoFrom + "'s இருப்பு\nசிறிய அளவு தேர்ந்தெடுக்கவும்";
                    else
                        bigDisplayLBL.Text = "Amount is larger than " + acctNoFrom + "'s balance\nSelect a smaller amount";

                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else
                {
                    nextStep = new ConfirmAmountTransferState(mainForm, language,
                        acctNoFrom,
                        acctNoTo,
                        transferAmt);
                }
            }

            return nextStep;
        }

        public override State handleRight2BTNClick()
        {
            amountEnteredTxt = "";
            smallDisplayLBL.Text = amountEnteredTxt;
            return this;
        }

        public override State handleRight4BTNClick()
        {
            return new ChooseAcctToTransferFundsFromState(mainForm, language);
        }

        private State processKey(string k)
        {
            State nextStep = this;

            amountEnteredTxt += k;
            smallDisplayLBL.Text = amountEnteredTxt;

            return nextStep;
        }
    }
}
