using System;
using System.Windows.Forms;

namespace WinFormsPractice
{
    public partial class BalanceForm : Form
    {
        public BalanceForm(int money)
        {
            InitializeComponent();
            lblBalance.Text += money.ToString() + " рублей.";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
