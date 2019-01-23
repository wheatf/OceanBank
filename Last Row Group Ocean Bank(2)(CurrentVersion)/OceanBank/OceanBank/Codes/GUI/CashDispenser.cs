using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    public class CashDispenser
    {
        private PictureBox cashDispenserControl;
        private static SoundPlayer clickSound;
        private static SoundPlayer cashSound;
        private static SoundPlayer cashReminderSound;

        static CashDispenser()
        {
            clickSound = new SoundPlayer(Properties.Resources.cardsound);
            clickSound.LoadAsync();
            cashSound = new SoundPlayer(Properties.Resources.cashdispensingsound);
            cashSound.LoadAsync();
            cashReminderSound = new SoundPlayer(Properties.Resources.cashremindersound);
            cashReminderSound.LoadAsync();
        }
        public CashDispenser(PictureBox p)
        {
            cashDispenserControl = p;
        }

        public void withoutCash()
        {
            cashDispenserControl.Image = Properties.Resources.CashDispenserEmpty;
        }

        public void removeCash()
        {
            cashDispenserControl.Image = Properties.Resources.CashDispenserEmpty;
            cashReminderSound.Stop();
            clickSound.PlaySync();
        }

        public void ejectCash()
        {
            cashSound.PlaySync();
            clickSound.PlaySync();
            cashReminderSound.PlayLooping();
            cashDispenserControl.Image = Properties.Resources.CashDispenserWithCash;
        }
    }
}
