using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsPractice
{
    public partial class InsertMoneyForm : Form
    {
        public int Money { get; private set; }
        public InsertMoneyForm()
        {
            InitializeComponent();
        }

        private void txtInsertMoney_Validating(object sender, CancelEventArgs e)
        {
            string input = txtInsertMoney.Text;
            if (!int.TryParse(input, out int money) || money <= 0 || money > 400000)
            {
                e.Cancel = true;
                errorInsertMoney.SetError(txtInsertMoney, "Неверная сумма.");
            }
            else
            {
                e.Cancel = false;
                errorInsertMoney.SetError(txtInsertMoney, string.Empty);
            }
        }

        private void txtInsertMoney_Validated(object sender, EventArgs e)
        {
            Money = int.Parse(txtInsertMoney.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }
    }
}
