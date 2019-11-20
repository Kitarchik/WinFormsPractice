using System.Collections.Generic;
using System.Linq;

namespace WinFormsPractice
{
    public class ClientRepository
    {
        private List<Client> _clients;

        public ClientRepository()
        {
            InitializeClients();
        }

        private void InitializeClients()
        {
            _clients = new List<Client>();
            _clients.Add(new Client("Роман", "Китар", "1234", 1000));
            _clients.Add(new Client("Сергей", "Никольский", "5678", 1000));
        }

        public Client GetClientByPin(string pinCode)
        {
            return _clients.FirstOrDefault(x => x.PinCode == pinCode);
        }
    }
}
