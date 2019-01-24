using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    class ViewAboutInfoState : State
    {
        public ViewAboutInfoState(GUIforATM mainForm, string language) : base(mainForm, language)
        {

            bigDisplayLBL.Text = "Last Row Group Ocean Bank is a large consumer banking company in Singapore and have a network of more than 500 ATMs machines located island-wide";
            smallDisplayLBL.Text = "";
            left1BTN.Text = ""; left2BTN.Text = ""; left3BTN.Text = ""; left4BTN.Text = "";
            right1BTN.Text = ""; right2BTN.Text = ""; right3BTN.Text = ""; right4BTN.Text = "Back to Main Menu";

        }

        public override State handleRight4BTNClick()
        {
            State nextStep = new DisplayMainMenuState(mainForm, language);
            return nextStep;
        }
    }
}
