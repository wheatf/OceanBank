using OceanBank.Codes.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    class WaitForBankCardState : State
    {
        public WaitForBankCardState(GUIforATM mainForm, string language) : base(mainForm, language)
        {
            if (language.ToUpper() == "CHINESE")
            {
                bigDisplayLBL.Text = "欢迎来到海洋银行\n请插入银行卡";
                smallDisplayLBL.Text = "";
            }
            else //ENGLISH
            {
                bigDisplayLBL.Text = "Welcome to Ocean Bank\nPlease insert card";
                smallDisplayLBL.Text = "";
            }

            left1BTN.Text = "English"; left2BTN.Text = "中文"; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "";
        }


        public override State handleRightPicBoxClick()
        {
            using (SelectCard selectCard = new SelectCard())
            {
                if(selectCard.ShowDialog(mainForm) == DialogResult.OK)
                {
                    int index = selectCard.Index;
                    mainForm.setCard(mainForm.getAllCards()[index]);
                }
                else
                {
                    return new WaitForBankCardState(mainForm, language);
                }
            }

                theCardReader.insertCard();
            State nextStep = new ValidatePINState(mainForm, language);
            return nextStep;
        }


        public override State handleLeft1BTNClick()
        {
            State nextStep = new WaitForBankCardState(mainForm, "ENGLISH");
            return nextStep;
        }

        public override State handleLeft2BTNClick()
        {
            State nextStep = new WaitForBankCardState(mainForm, "CHINESE");
            return nextStep;
        }

    }
}
