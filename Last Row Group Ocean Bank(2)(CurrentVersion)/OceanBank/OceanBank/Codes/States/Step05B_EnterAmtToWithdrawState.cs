using OceanBank.Codes.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class EnterAmtToWithdrawState : State
    {
        private string amountEnteredTxt;
        private string acctNo;

        public EnterAmtToWithdrawState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            this.acctNo = acctNo;

            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "退出账户 " + acctNo + "\n输入提款金额";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "好"; right2BTN.Text = "明确"; right3BTN.Text = ""; right4BTN.Text = "背部";
            }
            else if (language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Mengeluarkan dari Akaun " + acctNo + "\nMasukkan jumlah untuk menarik balik";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Ok"; right2BTN.Text = "Jelas"; right3BTN.Text = ""; right4BTN.Text = "Kembali";
            }
            else if (language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "கணக்கிலிருந்து வெளியேறவும் " + acctNo + "\nதிரும்பப் பெற அளவு உள்ளிடவும்";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "சரி"; right2BTN.Text = "தெளிவு"; right3BTN.Text = ""; right4BTN.Text = "மீண்டும்";
            }
            else
            {
                bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nEnter amount to withdraw";
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
            State nextStep = new EnterAmtToWithdrawState(mainForm, language, acctNo);

            double withdrawAmt;
            Account withdrawFromAcct;

            withdrawFromAcct = theCard.getAcctUsingAcctNo(acctNo);
            //withdrawFromAcct.withdraw(withdrawAmt);

            // input is empty
            if (string.IsNullOrWhiteSpace(amountEnteredTxt))
            {
                if(language.ToUpper() == "CHINESE")
                    bigDisplayLBL.Text = "退出账户 " + acctNo + "\n请输入金额";
                else if(language.ToUpper() == "MALAY")
                    bigDisplayLBL.Text = "Mengeluarkan dari Akaun " + acctNo + "\nSila masukkan amaun";
                else if(language.ToUpper() == "TAMIL")
                    bigDisplayLBL.Text = "கணக்கிலிருந்து வெளியேறவும் " + acctNo + "\nதயவுசெய்து ஒரு அளவு உள்ளிடவும்";
                else
                    bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nPlease enter an amount";

                amountEnteredTxt = "";
                smallDisplayLBL.Text = amountEnteredTxt;
            }
            //// input is not numeric
            //else if(!amountEnteredTxt.IsDouble())
            //{
            //    bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nOnly numeric values are allowed";
            //    amountEnteredTxt = "";
            //    smallDisplayLBL.Text = amountEnteredTxt;
            //}
            else
            {
                withdrawAmt = Convert.ToDouble(amountEnteredTxt);

                // input is less than or equals 0
                if(withdrawAmt <= 0)
                {
                    if(language.ToUpper() == "CHINESE")
                        bigDisplayLBL.Text = "退出账户 " + acctNo + "\n请输入大于0的金额";
                    else if(language.ToUpper() == "MALAY")
                        bigDisplayLBL.Text = "Mengeluarkan dari Akaun " + acctNo + "\nSila masukkan jumlah yang lebih besar daripada 0";
                    else if(language.ToUpper() == "TAMIL")
                        bigDisplayLBL.Text = "கணக்கிலிருந்து வெளியேறவும் " + acctNo + "\n0 ஐ விட பெரிய அளவு உள்ளிடவும்";
                    else
                        bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nPlease enter an amount larger than 0";

                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                // input is not in mutiples of 10
                else if (withdrawAmt % 10d != 0)
                {
                    if(language.ToUpper() == "CHINESE")
                        bigDisplayLBL.Text = "退出账户 " + acctNo + "\n请输入10或100的倍数";
                    else if(language.ToUpper() == "MALAY")
                        bigDisplayLBL.Text = "Mengeluarkan dari Akaun " + acctNo + "\nSila masukkan dalam gandaan 10 atau 100";
                    else if(language.ToUpper() == "TAMIL")
                        bigDisplayLBL.Text = "கணக்கிலிருந்து வெளியேறவும் " + acctNo + "\nதயவுசெய்து 10 அல்லது 100 மடங்குகளில் உள்ளிடவும்";
                    else
                        bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nPlease enter in multiples of 10 or 100";

                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else if (withdrawAmt > withdrawFromAcct.getBalance())
                {
                    if(language.ToUpper() == "CHINESE")
                        bigDisplayLBL.Text = "退出账户 " + acctNo + "\n金额大于您的余额\n选择较小的金额";
                    else if(language.ToUpper() == "MALAY")
                        bigDisplayLBL.Text = "Mengeluarkan dari Akaun " + acctNo + "\nJumlah lebih besar daripada baki anda\nPilih jumlah yang lebih kecil";
                    else if(language.ToUpper() == "TAMIL")
                        bigDisplayLBL.Text = "கணக்கிலிருந்து வெளியேறவும் " + acctNo + "\nஉங்கள் சமநிலையை விட தொகை அதிகமாக உள்ளது\nசிறிய அளவு தேர்ந்தெடுக்கவும்";
                    else
                        bigDisplayLBL.Text = "Withdraw from Account " + acctNo + "\nAmount is larger than your balance\nSelect a smaller amount";

                    amountEnteredTxt = "";
                    smallDisplayLBL.Text = amountEnteredTxt;
                }
                else
                {
                    withdrawFromAcct.withdraw(withdrawAmt);
                    nextStep = new TakeCashState(mainForm, language, acctNo);
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
            State nextStep = new ChooseAcctToWithdrawState(mainForm, language);
            return nextStep;
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
