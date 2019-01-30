using OceanBank.Codes.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    class InsertCashDepositState : State
    {
        private string acctNo;
        private double amount;

        private bool cashInserted = false;

        private Timer timer;
        private int counter;

        public InsertCashDepositState(GUIforATM mainForm, string language, string acctNo) : base(mainForm, language)
        {
            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "将现金插入现金槽\n仅允许10新元，50日，100日元，1000日元的钞票";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "继续"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "背部";
            }
            else if (language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Masukkan tunai ke dalam slot tunai\nHanya nota SGD 10, 50, 100, 1000 dibenarkan";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Teruskan"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Kembali";
            }
            else if (language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "ரொக்க ஸ்லாட்டில் ரொக்கத்தைச் செருகவும்\nSGD 10, 50, 100, 1000 குறிப்புகள் மட்டுமே அனுமதிக்கப்படுகின்றன";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "தொடர்ந்து"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "மீண்டும்";
            }
            else
            {
                bigDisplayLBL.Text = "Insert cash into the cash slot\nOnly notes of SGD 10, 50, 100, 1000 are allowed";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Continue"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back";
            }

            counter = 120;
            this.acctNo = acctNo;

            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer.Stop();
                mainForm.GoToState(new DisplayMainMenuState(mainForm, language));
            }
        }

        public override State handleLeftPicBoxClick()
        {
            if (cashInserted)
            {
                amount = 0;
                theCashSlot.removeCash();
            }
            else
            {
                using (DepositAmount depositAmount = new DepositAmount())
                {
                    if (depositAmount.ShowDialog(mainForm) == DialogResult.OK)
                    {
                        amount = depositAmount.Amount;
                        theCashSlot.insertCash();
                    }
                }
            }

            cashInserted = !cashInserted;
            return this;
        }

        public override State handleRight1BTNClick()
        {
            if(language.ToUpper() == "CHINESE")
                bigDisplayLBL.Text = "制表现金...";
            else if(language.ToUpper() == "MALAY")
                bigDisplayLBL.Text = "Tabulasi Tunai...";
            else if(language.ToUpper() == "TAMIL")
                bigDisplayLBL.Text = "பணத்தை திருப்புதல்...";
            else
                bigDisplayLBL.Text = "Tabulating Cash...";

            timer.Stop();
            theCashSlot.tabulateCash();

            if (amount <= 0)
            {
                if(language.ToUpper() == "CHINESE")
                    bigDisplayLBL.Text = "未检测到任何注释, 请重试\n将现金插入现金槽\n仅允许10新元，50日，100日元，1000日元的钞票";
                else if(language.ToUpper() == "MALAY")
                    bigDisplayLBL.Text = "Tiada nota yang dikesan, cuba lagi\nMasukkan tunai ke dalam slot tunai\nHanya nota SGD 10, 50, 100, 1000 dibenarkan";
                else if(language.ToUpper() == "TAMIL")
                    bigDisplayLBL.Text = "குறிப்புகள் கண்டறியப்படவில்லை, மீண்டும் முயற்சிக்கவும்\nரொக்க ஸ்லாட்டில் ரொக்கத்தைச் செருகவும்\nSGD 10, 50, 100, 1000 குறிப்புகள் மட்டுமே அனுமதிக்கப்படுகின்றன";
                else
                    bigDisplayLBL.Text = "No notes detected, try again\nInsert cash into the cash slot\nOnly notes of SGD 10, 50, 100, 1000 are allowed";

                timer.Start();
                theCashSlot.withoutCash();
                cashInserted = false;
                return this;
            }
            else if (Math.Abs(amount % 1) > (double.Epsilon * 100))
            {
                string error;
                if (language.ToUpper() == "CHINESE")
                    error = "只接受笔记\n请删除现金";
                else if (language.ToUpper() == "MALAY")
                    error = "Hanya menerima nota\nSila keluarkan wang tunai";
                else if(language.ToUpper() == "TAMIL")
                    error = "குறிப்புகளை மட்டும் ஏற்றுக்கொள்க\nபணத்தை அகற்றவும்";
                else
                    error = "Only accept notes\nPlease remove cash";

                return new RejectTabulatedCashState(mainForm, language, acctNo, error);
            }
            else if (amount % 10 != 0)
            {
                string error;
                if (language.ToUpper() == "CHINESE")
                    error = "只允许10美元, 50美元, 100美元, 1000美元\n请删除现金";
                else if(language.ToUpper() == "MALAY")
                    error = "Hanya $10, $50, $100, $1000 dibenarkan\nSila keluarkan wang tunai";
                else if(language.ToUpper() == "TAMIL")
                    error = "$10, $50, $100, $1000 மட்டுமே அனுமதிக்கப்படும்\nபணத்தை அகற்றவும்";
                else
                    error = "Only $10, $50, $100, $1000 are allowed\nPlease remove cash";

                return new RejectTabulatedCashState(mainForm, language, acctNo, error);
            }
            else
            {
                return new DisplayTabulatedCash(mainForm, language, acctNo, amount);
            }
        }

        public override State handleRight4BTNClick()
        {
            timer.Stop();
            theCashSlot.withoutCash();
            return new ChooseAcctToDepositState(mainForm, language);
        }
    }
}
