using System;
using System.Windows.Forms;

namespace WinFormsPractice
{
    public partial class MainForm : Form
    {
        private Client _currentClient;
        private ClientRepository _clientRepository;
        public MainForm()
        {
            InitializeComponent();
            _currentClient = null;
            _clientRepository = new ClientRepository();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.OK;
            while (_currentClient == null && dialogResult == DialogResult.OK)
            {
                PinForm pinForm = new PinForm();
                dialogResult = pinForm.ShowDialog();
                _currentClient = _clientRepository.GetClientByPin(pinForm.PinCode);
                if (_currentClient == null)
                {
                    MessageBox.Show("Неверный ПИН код");
                }
            }

            if (dialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm = new BalanceForm(_currentClient.Money);
            balanceForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertMoney_Click(object sender, EventArgs e)
        {
            InsertMoneyForm insertMoneyForm = new InsertMoneyForm();
            if (insertMoneyForm.ShowDialog() == DialogResult.OK)
            {
                _currentClient.AddMoney(insertMoneyForm.Money);
            }
        }
    }
}
