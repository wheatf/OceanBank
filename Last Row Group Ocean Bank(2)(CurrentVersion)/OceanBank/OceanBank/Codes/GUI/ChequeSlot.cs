using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    public class ChequeSlot
    {
        private PictureBox chequeSlot;
        private static SoundPlayer clickSound;
        private static SoundPlayer chequeReminderSound;
        private static SoundPlayer chequeTabulatingSound;
        private static SoundPlayer chequeSound;

        static ChequeSlot()
        {
            clickSound = new SoundPlayer(Properties.Resources.cardsound);
            clickSound.LoadAsync();
            chequeReminderSound = new SoundPlayer(Properties.Resources.cashremindersound);
            chequeReminderSound.LoadAsync();
            chequeTabulatingSound = new SoundPlayer(Properties.Resources.atm_tabulatingcash);
            chequeTabulatingSound.LoadAsync();
            chequeSound = new SoundPlayer(Properties.Resources.paper_flutter);
            chequeSound.LoadAsync();
        }

        public ChequeSlot(PictureBox p)
        {
            chequeSlot = p;
        }

        public void insertCheque()
        {
            clickSound.PlaySync();
            chequeSound.Play();
            chequeSlot.Image = Properties.Resources.CashDispenserWithCash;
        }

        public void showCheque()
        {
            clickSound.PlaySync();
            chequeReminderSound.PlayLooping();
            chequeSlot.Image = Properties.Resources.CashDispenserWithCash;
        }

        public void withoutCheque()
        {
            chequeReminderSound.Stop();
            clickSound.PlaySync();
            chequeSlot.Image = Properties.Resources.CardReaderWithoutCard;
        }

        public void tabulateCheque()
        {
            chequeSlot.Image = Properties.Resources.CardReaderWithoutCard;
            chequeTabulatingSound.PlaySync();
        }
    }
}
