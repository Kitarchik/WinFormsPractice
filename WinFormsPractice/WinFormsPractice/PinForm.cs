using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsPractice
{
    public partial class PinForm : Form
    {
        public string PinCode { get; private set; }
        public PinForm()
        {
            InitializeComponent();
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

        private void txtPinCode_Validating(object sender, CancelEventArgs e)
        {
            string input = txtPinCode.Text;
            if (input.Length != 4 || !int.TryParse(input, out int result))
            {
                e.Cancel = true;
                errorPinCode.SetError(txtPinCode, "ПИН код должен состоять из 4 цифр.");
            }
            else
            {
                e.Cancel = false;
                errorPinCode.SetError(txtPinCode,string.Empty);
            }
        }

        private void txtPinCode_Validated(object sender, EventArgs e)
        {
            PinCode = txtPinCode.Text;
        }
    }
}
