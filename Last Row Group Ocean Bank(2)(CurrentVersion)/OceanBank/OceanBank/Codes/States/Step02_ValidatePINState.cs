using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    class ValidatePINState : State
    {
        private int noDigitsForPIN = 6;
        private string PINentered;

        public ValidatePINState(GUIforATM mainForm, string language) : base(mainForm, language)
        {
            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "请输入密码";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else //ENGLISH
            {
                bigDisplayLBL.Text = "Please enter PIN";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }

            PINentered = "";
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

        private Boolean validatePIN()
        {
            if (PINentered == theCard.getPIN())
                return true;
            else
                return false;
        }

        private State processKey(string k)
        {
            State nextStep = this;

            if (PINentered.Length < noDigitsForPIN)
            {
                PINentered += k;
                smallDisplayLBL.Text = PINentered;
                smallDisplayLBL.Refresh();
                if (PINentered.Length == noDigitsForPIN)
                {
                    if (validatePIN() == true)
                    {
                        nextStep = new DisplayMainMenuState(mainForm, language);
                    }
                    else
                    {
                        if (language.ToUpper() == "CHINESE")
                            bigDisplayLBL.Text = "错误密码";
                        else
                            bigDisplayLBL.Text = "Wrong PIN";
                        bigDisplayLBL.Refresh();

                        pauseforMilliseconds(1000);
                        if (language.ToUpper() == "CHINESE")
                            bigDisplayLBL.Text = "请再次输入密码";
                        else
                            bigDisplayLBL.Text = "Please enter PIN again";
                        smallDisplayLBL.Text = "";
                        PINentered = "";
                        nextStep = this;
                    }
                }

            }
            return nextStep;
        }

    }
}
