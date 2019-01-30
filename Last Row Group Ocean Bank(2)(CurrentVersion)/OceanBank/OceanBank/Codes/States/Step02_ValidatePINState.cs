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
        private static readonly int MAX_NO_OF_TRIES = 3;
        private static int noOfTries = 1;
        private int noDigitsForPIN = 6;
        private string PINentered;

        public ValidatePINState(GUIforATM mainForm, string language) : base(mainForm, language)
        {
            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "请输入密码";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "明确"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "MALAY")
            {
                bigDisplayLBL.Text = "Sila masukkan PIN";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Jelas"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else if(language.ToUpper() == "TAMIL")
            {
                bigDisplayLBL.Text = "PIN ஐ உள்ளிடுக";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "தெளிவு"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }
            else //ENGLISH
            {
                bigDisplayLBL.Text = "Please enter PIN";
                smallDisplayLBL.Text = "";
                left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
                right1BTN.Text = "Clear"; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
            }

            PINentered = "";
        }

        public override State handleRight1BTNClick()
        {
            PINentered = "";
            smallDisplayLBL.Text = "";
            return this;
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

        private bool validatePIN()
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
                smallDisplayLBL.Text += '*';
                smallDisplayLBL.Refresh();
                if (PINentered.Length == noDigitsForPIN)
                {
                    if (validatePIN() == true)
                    {
                        nextStep = new DisplayMainMenuState(mainForm, language);
                        noOfTries = 1;
                    }
                    else
                    {
                        noOfTries++;

                        if (noOfTries <= MAX_NO_OF_TRIES)
                        {
                            if (language.ToUpper() == "CHINESE")
                                bigDisplayLBL.Text = "错误密码";
                            else if (language.ToUpper() == "MALAY")
                                bigDisplayLBL.Text = "PIN salah";
                            else if (language.ToUpper() == "TAMIL")
                                bigDisplayLBL.Text = "தவறான PIN";
                            else
                                bigDisplayLBL.Text = "Wrong PIN";
                            bigDisplayLBL.Refresh();

                            pauseforMilliseconds(1000);

                            if(noOfTries == MAX_NO_OF_TRIES)
                            {
                                if (language.ToUpper() == "CHINESE")
                                    bigDisplayLBL.Text = "!!! 最后一次尝试 !!!\n请再次输入密码";
                                else if (language.ToUpper() == "MALAY")
                                    bigDisplayLBL.Text = "!!! Percubaan terakhir !!!\nSila masukkan PIN lagi";
                                else if (language.ToUpper() == "TAMIL")
                                    bigDisplayLBL.Text = "!!! கடைசி முயற்சி !!!\nமீண்டும் PIN ஐ உள்ளிடுக";
                                else
                                    bigDisplayLBL.Text = "!!! LAST ATTEMPT !!!\nPlease enter PIN again";
                            }
                            else
                            {
                                if (language.ToUpper() == "CHINESE")
                                    bigDisplayLBL.Text = "请再次输入密码";
                                else if (language.ToUpper() == "MALAY")
                                    bigDisplayLBL.Text = "Sila masukkan PIN lagi";
                                else if (language.ToUpper() == "TAMIL")
                                    bigDisplayLBL.Text = "மீண்டும் PIN ஐ உள்ளிடுக";
                                else
                                    bigDisplayLBL.Text = "Please enter PIN again";
                            }

                            smallDisplayLBL.Text = "";
                            PINentered = "";
                            nextStep = this;
                        }
                        else
                        {
                            nextStep = new RemoveCardState(mainForm, language);
                            noOfTries = 1;
                        }
                    }
                }

            }
            return nextStep;
        }

    }
}
