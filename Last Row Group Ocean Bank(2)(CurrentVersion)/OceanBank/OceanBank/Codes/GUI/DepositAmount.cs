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

namespace OceanBank.Codes.GUI
{
    public partial class DepositAmount : Form
    {
        public double Amount { get; set; }

        public DepositAmount()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AmountText.Text))
            {
                MessageBox.Show("Please enter a value!");
                AmountText.Clear();
            }
            else if (!AmountText.Text.IsDouble())
            {
                MessageBox.Show("Only numeric value is allowed!");
                AmountText.Clear();
            }
            else if (Convert.ToDouble(AmountText.Text) < 0)
            {
                MessageBox.Show("Only positive valeus are allowed!");
                AmountText.Clear();
            }
            else
            {
                Amount = Convert.ToDouble(AmountText.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
