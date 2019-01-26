using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    public class CashSlot
    {
        private PictureBox cashSlot;
        private static SoundPlayer clickSound;
        private static SoundPlayer cashSound;
        private static SoundPlayer cashReminderSound;
        private static SoundPlayer cashTabulatingSound;

        static CashSlot()
        {
            clickSound = new SoundPlayer(Properties.Resources.cardsound);
            clickSound.LoadAsync();
            cashSound = new SoundPlayer(Properties.Resources.cashdispensingsound);
            cashSound.LoadAsync();
            cashReminderSound = new SoundPlayer(Properties.Resources.cashremindersound);
            cashReminderSound.LoadAsync();
            cashTabulatingSound = new SoundPlayer(Properties.Resources.atm_tabulatingcash);
            cashTabulatingSound.LoadAsync();
        }
        public CashSlot(PictureBox p)
        {
            cashSlot = p;
        }

        public void withoutCash()
        {
            cashSlot.Image = Properties.Resources.CashDispenserEmpty;
        }

        public void removeCash()
        {
            cashSlot.Image = Properties.Resources.CashDispenserEmpty;
            cashReminderSound.Stop();
            clickSound.PlaySync();
        }

        public void ejectCash()
        {
            cashSound.PlaySync();
            clickSound.PlaySync();
            cashReminderSound.PlayLooping();
            cashSlot.Image = Properties.Resources.CashDispenserWithCash;
        }

        public void insertCash()
        {
            cashSlot.Image = Properties.Resources.CashDispenserWithCash;
            clickSound.PlaySync();
        }

        public void tabulateCash()
        {
            cashSlot.Image = Properties.Resources.CashDispenserEmpty;
            cashTabulatingSound.PlaySync();
        }
    }
}
