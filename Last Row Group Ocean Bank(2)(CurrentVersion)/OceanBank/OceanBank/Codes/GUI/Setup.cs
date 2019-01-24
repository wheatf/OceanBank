using OceanBank.Codes.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanBank
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // Validation
            if (User1PINIsEmpty())
            {
                MessageBox.Show("User 1 PIN is empty!");
                return;
            }
            if (User1PINIsInvalid())
            {
                MessageBox.Show("User 1 PIN must be 6-digit long!");
                return;
            }

            if (User2PINIsEmpty())
            {
                MessageBox.Show("User 2 PIN is empty!");
                return;
            }
            if (User2PINIsInvalid())
            {
                MessageBox.Show("User 2 PIN must be 6-digit long!");
                return;
            }

            if (User3PINIsEmpty())
            {
                MessageBox.Show("User 3 PIN is empty!");
                return;
            }
            if (User3PINIsInvalid())
            {
                MessageBox.Show("User 3 PIN must be 6-digit long!");
                return;
            }

            if (User1HasNoAccount())
            {
                MessageBox.Show("User 1 needs to have at least an account!");
                return;
            }
            if (User2HasNoAccount())
            {
                MessageBox.Show("User 2 needs to have at least an account!");
                return;
            }
            if (User3HasNoAccount())
            {
                MessageBox.Show("User 3 needs to have at least an account!");
                return;
            }

            if (User1Account1IsIncomplete())
            {
                MessageBox.Show("User 1's Account 1 is incomplete!");
                return;
            }
            if (User1Account2IsIncomplete())
            {
                MessageBox.Show("User 1's Account 2 is incomplete!");
                return;
            }
            if (User1Account3IsIncomplete())
            {
                MessageBox.Show("User 1's Account 3 is incomplete!");
                return;
            }
            if (User1Account4IsIncomplete())
            {
                MessageBox.Show("User 1's Account 4 is incomplete!");
                return;
            }
            if (User1Account5IsIncomplete())
            {
                MessageBox.Show("User 1's Account 5 is incomplete!");
                return;
            }

            if (User2Account1IsIncomplete())
            {
                MessageBox.Show("User 2's Account 1 is incomplete!");
                return;
            }
            if (User2Account2IsIncomplete())
            {
                MessageBox.Show("User 2's Account 2 is incomplete!");
                return;
            }
            if (User2Account3IsIncomplete())
            {
                MessageBox.Show("User 2's Account 3 is incomplete!");
                return;
            }
            if (User2Account4IsIncomplete())
            {
                MessageBox.Show("User 2's Account 4 is incomplete!");
                return;
            }
            if (User2Account5IsIncomplete())
            {
                MessageBox.Show("User 2's Account 5 is incomplete!");
                return;
            }

            if (User3Account1IsIncomplete())
            {
                MessageBox.Show("User 3's Account 1 is incomplete!");
                return;
            }
            if (User3Account2IsIncomplete())
            {
                MessageBox.Show("User 3's Account 2 is incomplete!");
                return;
            }
            if (User3Account3IsIncomplete())
            {
                MessageBox.Show("User 3's Account 3 is incomplete!");
                return;
            }
            if (User3Account4IsIncomplete())
            {
                MessageBox.Show("User 3's Account 4 is incomplete!");
                return;
            }
            if (User3Account5IsIncomplete())
            {
                MessageBox.Show("User 3's Account 5 is incomplete!");
                return;
            }

            if (User1Account1BalanceIsNotDouble())
            {
                MessageBox.Show("User 1's Account 1's Balance is not numeric!");
                return;
            }
            if (User1Account2BalanceIsNotDouble())
            {
                MessageBox.Show("User 1's Account 2's Balance is not numeric!");
                return;
            }
            if (User1Account3BalanceIsNotDouble())
            {
                MessageBox.Show("User 1's Account 3's Balance is not numeric!");
                return;
            }
            if (User1Account4BalanceIsNotDouble())
            {
                MessageBox.Show("User 1's Account 4's Balance is not numeric!");
                return;
            }
            if (User1Account5BalanceIsNotDouble())
            {
                MessageBox.Show("User 1's Account 5's Balance is not numeric!");
                return;
            }
            if (User2Account1BalanceIsNotDouble())
            {
                MessageBox.Show("User 2's Account 1's Balance is not numeric!");
                return;
            }
            if (User2Account2BalanceIsNotDouble())
            {
                MessageBox.Show("User 2's Account 2's Balance is not numeric!");
                return;
            }
            if (User2Account3BalanceIsNotDouble())
            {
                MessageBox.Show("User 2's Account 3's Balance is not numeric!");
                return;
            }
            if (User2Account4BalanceIsNotDouble())
            {
                MessageBox.Show("User 2's Account 4's Balance is not numeric!");
                return;
            }
            if (User2Account5BalanceIsNotDouble())
            {
                MessageBox.Show("User 2's Account 5's Balance is not numeric!");
                return;
            }
            if (User3Account1BalanceIsNotDouble())
            {
                MessageBox.Show("User 3's Account 1's Balance is not numeric!");
                return;
            }
            if (User3Account2BalanceIsNotDouble())
            {
                MessageBox.Show("User 3's Account 2's Balance is not numeric!");
                return;
            }
            if (User3Account3BalanceIsNotDouble())
            {
                MessageBox.Show("User 3's Account 3's Balance is not numeric!");
                return;
            }
            if (User3Account4BalanceIsNotDouble())
            {
                MessageBox.Show("User 3's Account 4's Balance is not numeric!");
                return;
            }
            if (User3Account5BalanceIsNotDouble())
            {
                MessageBox.Show("User 3's Account 5's Balance is not numeric!");
                return;
            }

            // Feeding GUIforATM
            List<Card> cards = new List<Card>();
            List<Account> accounts = new List<Account>();
            // User 1
            if (!User1Account1IsEmpty())
            {
                accounts.Add(new Account(
                    User1Account1AccountNoText.Text,
                    Convert.ToDouble(User1Account1BalanceText.Text)));
            }
            if (!User1Account2IsEmpty())
            {
                accounts.Add(new Account(
                    User1Account2AccountNoText.Text,
                    Convert.ToDouble(User1Account2BalanceText.Text)));
            }
            if (!User1Account3IsEmpty())
            {
                accounts.Add(new Account(
                    User1Account3AccountNoText.Text,
                    Convert.ToDouble(User1Account3BalanceText.Text)));
            }
            if (!User1Account4IsEmpty())
            {
                accounts.Add(new Account(
                    User1Account4AccountNoText.Text,
                    Convert.ToDouble(User1Account4BalanceText.Text)));
            }
            if (!User1Account5IsEmpty())
            {
                accounts.Add(new Account(
                    User1Account5AccountNoText.Text,
                    Convert.ToDouble(User1Account5BalanceText.Text)));
            }
            cards.Add(new Card(User1PINText.Text, accounts));
            accounts = new List<Account>();

            // User 2
            if (!User2Account1IsEmpty())
            {
                accounts.Add(new Account(
                    User2Account1AccountNoText.Text,
                    Convert.ToDouble(User2Account1BalanceText.Text)));
            }
            if (!User2Account2IsEmpty())
            {
                accounts.Add(new Account(
                    User2Account2AccountNoText.Text,
                    Convert.ToDouble(User2Account2BalanceText.Text)));
            }
            if (!User2Account3IsEmpty())
            {
                accounts.Add(new Account(
                    User2Account3AccountNoText.Text,
                    Convert.ToDouble(User2Account3BalanceText.Text)));
            }
            if (!User2Account4IsEmpty())
            {
                accounts.Add(new Account(
                    User2Account4AccountNoText.Text,
                    Convert.ToDouble(User2Account4BalanceText.Text)));
            }
            if (!User2Account5IsEmpty())
            {
                accounts.Add(new Account(
                    User2Account5AccountNoText.Text,
                    Convert.ToDouble(User2Account5BalanceText.Text)));
            }
            cards.Add(new Card(User2PINText.Text, accounts));
            accounts = new List<Account>();

            // User 3
            if (!User3Account1IsEmpty())
            {
                accounts.Add(new Account(
                    User3Account1AccountNoText.Text,
                    Convert.ToDouble(User3Account1BalanceText.Text)));
            }
            if (!User3Account2IsEmpty())
            {
                accounts.Add(new Account(
                    User3Account2AccountNoText.Text,
                    Convert.ToDouble(User3Account2BalanceText.Text)));
            }
            if (!User3Account3IsEmpty())
            {
                accounts.Add(new Account(
                    User3Account3AccountNoText.Text,
                    Convert.ToDouble(User3Account3BalanceText.Text)));
            }
            if (!User3Account4IsEmpty())
            {
                accounts.Add(new Account(
                    User3Account4AccountNoText.Text,
                    Convert.ToDouble(User3Account4BalanceText.Text)));
            }
            if (!User3Account5IsEmpty())
            {
                accounts.Add(new Account(
                    User3Account5AccountNoText.Text,
                    Convert.ToDouble(User3Account5BalanceText.Text)));
            }
            cards.Add(new Card(User3PINText.Text, accounts));
            accounts = null;

            (new GUIforATM(cards)).Show();
        }

        private bool User1PINIsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User1PINText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User1PINIsInvalid()
        {
            if(User1PINText.Text.Length != 6 || !User1PINText.Text.IsInt())
            {
                return true;
            }

            return false;
        }

        private bool User2PINIsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User2PINText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User2PINIsInvalid()
        {
            if (User2PINText.Text.Length != 6 || !User2PINText.Text.IsInt())
            {
                return true;
            }

            return false;
        }

        private bool User3PINIsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User3PINText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User3PINIsInvalid()
        {
            if (User3PINText.Text.Length != 6 || !User3PINText.Text.IsInt())
            {
                return true;
            }

            return false;
        }

        private bool User1HasNoAccount()
        {
            if(User1Account1IsEmpty() && User1Account2IsEmpty() && 
                User1Account3IsEmpty() &&
                User1Account4IsEmpty() &&
                User1Account5IsEmpty())
            {
                return true;
            }

            return false;
        }

        private bool User1Account1IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User1Account1AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User1Account1BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User1Account1IsIncomplete()
        {
            if (!User1Account1IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User1Account1AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User1Account1BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User1Account1BalanceIsNotDouble()
        {
            if (!User1Account1IsEmpty() && !User1Account1BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User1Account2IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User1Account2AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User1Account2BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User1Account2IsIncomplete()
        {
            if (!User1Account2IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User1Account2AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User1Account2BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User1Account2BalanceIsNotDouble()
        {
            if (!User1Account2IsEmpty() && !User1Account2BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User1Account3IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User1Account3AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User1Account3BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User1Account3IsIncomplete()
        {
            if (!User1Account3IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User1Account3AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User1Account3BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User1Account3BalanceIsNotDouble()
        {
            if (!User1Account3IsEmpty() && !User1Account3BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User1Account4IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User1Account4AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User1Account4BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User1Account4IsIncomplete()
        {
            if (!User1Account4IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User1Account4AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User1Account4BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User1Account4BalanceIsNotDouble()
        {
            if (!User1Account4IsEmpty() && !User1Account4BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User1Account5IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User1Account5AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User1Account5BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User1Account5IsIncomplete()
        {
            if (!User1Account5IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User1Account5AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User1Account5BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User1Account5BalanceIsNotDouble()
        {
            if (!User1Account5IsEmpty() && !User1Account5BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }


        private bool User2HasNoAccount()
        {
            if (User2Account1IsEmpty() && User2Account2IsEmpty() &&
                User2Account3IsEmpty() &&
                User2Account4IsEmpty() &&
                User2Account5IsEmpty())
            {
                return true;
            }

            return false;
        }

        private bool User2Account1IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User2Account1AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User2Account1BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User2Account1IsIncomplete()
        {
            if (!User2Account1IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User2Account1AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User2Account1BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User2Account1BalanceIsNotDouble()
        {
            if (!User2Account1IsEmpty() && !User2Account1BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User2Account2IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User2Account2AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User2Account2BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User2Account2IsIncomplete()
        {
            if (!User2Account2IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User2Account2AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User2Account2BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User2Account2BalanceIsNotDouble()
        {
            if (!User2Account2IsEmpty() && !User2Account2BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User2Account3IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User2Account3AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User2Account3BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User2Account3IsIncomplete()
        {
            if (!User2Account3IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User2Account3AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User2Account3BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User2Account3BalanceIsNotDouble()
        {
            if (!User2Account3IsEmpty() && !User2Account3BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User2Account4IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User2Account4AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User2Account4BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User2Account4IsIncomplete()
        {
            if (!User2Account4IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User2Account4AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User2Account4BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User2Account4BalanceIsNotDouble()
        {
            if (!User2Account4IsEmpty() && !User2Account4BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User2Account5IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User2Account5AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User2Account5BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User2Account5IsIncomplete()
        {
            if (!User2Account5IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User2Account5AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User2Account5BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User2Account5BalanceIsNotDouble()
        {
            if (!User2Account5IsEmpty() && !User2Account5BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }


        private bool User3HasNoAccount()
        {
            if (User3Account1IsEmpty() && User3Account2IsEmpty() &&
                User3Account3IsEmpty() &&
                User3Account4IsEmpty() &&
                User3Account5IsEmpty())
            {
                return true;
            }

            return false;
        }

        private bool User3Account1IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User3Account1AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User3Account1BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User3Account1IsIncomplete()
        {
            if (!User3Account1IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User3Account1AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User3Account1BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User3Account1BalanceIsNotDouble()
        {
            if (!User3Account1IsEmpty() && !User3Account1BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User3Account2IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User3Account2AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User3Account2BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User3Account2IsIncomplete()
        {
            if (!User3Account2IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User3Account2AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User3Account2BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User3Account2BalanceIsNotDouble()
        {
            if (!User3Account2IsEmpty() && !User3Account2BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User3Account3IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User3Account3AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User3Account3BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User3Account3IsIncomplete()
        {
            if (!User3Account3IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User3Account3AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User3Account3BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User3Account3BalanceIsNotDouble()
        {
            if (!User3Account3IsEmpty() && !User3Account3BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User3Account4IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User3Account4AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User3Account4BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User3Account4IsIncomplete()
        {
            if (!User3Account4IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User3Account4AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User3Account4BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User3Account4BalanceIsNotDouble()
        {
            if (!User3Account4IsEmpty() && !User3Account4BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }

        private bool User3Account5IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(User3Account5AccountNoText.Text)
                && string.IsNullOrWhiteSpace(User3Account5BalanceText.Text))
            {
                return true;
            }

            return false;
        }

        private bool User3Account5IsIncomplete()
        {
            if (!User3Account5IsEmpty())
            {
                if (string.IsNullOrWhiteSpace(User3Account5AccountNoText.Text)
                    || string.IsNullOrWhiteSpace(User3Account5BalanceText.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private bool User3Account5BalanceIsNotDouble()
        {
            if (!User3Account5IsEmpty() && !User3Account5BalanceText.Text.IsDouble())
            {
                return true;
            }

            return false;
        }
    }
}
