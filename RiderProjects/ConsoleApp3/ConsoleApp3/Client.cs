namespace ConsoleApp3
{
    public class Client
    {
        public string name { get; set; }
        public int hour { get; set; }

        public Client(string _name, int _hour)
        {
            name = _name;
            hour = _hour;
        }
        public int CalculateCharges()
        {
            int price;
            if (hour == 24)
                price = 10;
            else if (hour > 3)
                price = 2 + (hour - 3) / 2;
            else
                price = 2;
            return price;
        }
        public override string ToString()
        {
            return $"{name} payed {CalculateCharges()}.00 $ because he stayed {hour} hours on the parking";
        }
    }
}