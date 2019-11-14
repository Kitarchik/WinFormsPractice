namespace WinFormsPractice
{
    public class Client
    {
        public string Name { get; }
        public string Surname { get; }
        public string PinCode { get; }
        public int Money { get; private set; }
        public Client(string name, string surname, string pinCode, int money)
        {
            Name = name;
            Surname = surname;
            PinCode = pinCode;
            Money = money;
        }

        public void InsertMoney(int money)
        {
            if (money > 0 && money < 400000)
            {
                Money += money;
            }
        }
    }
}
