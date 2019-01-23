using System;
using System.Windows.Forms;

namespace OceanBank.Codes.GUI
{
    public partial class SelectCard : Form
    {
        public int Index { get; set; }

        public SelectCard()
        {
            InitializeComponent();
        }

        private void User1OK_Click(object sender, EventArgs e)
        {
            Index = 0;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void User2OK_Click(object sender, EventArgs e)
        {
            Index = 1;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void User3OK_Click(object sender, EventArgs e)
        {
            Index = 2;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
