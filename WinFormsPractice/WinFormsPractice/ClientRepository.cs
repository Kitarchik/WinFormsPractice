using System.Collections.Generic;
using System.Linq;

namespace WinFormsPractice
{
    public class ClientRepository
    {
        private List<Client> _clients;

        public ClientRepository()
        {
            Initialize();
        }

        public Client GetClientByPin(string pin)
        {
            return _clients.FirstOrDefault(x => x.PinCode == pin);
        }

        private void Initialize()
        {
            _clients = new List<Client>
            {
                new Client("John", "Doe", "1234", 1000),
                new Client("Китар", "Роман", "4581", 1000),
                new Client("Сергей", "Никольский", "3567", 1000),
            };
        }
    }
}
