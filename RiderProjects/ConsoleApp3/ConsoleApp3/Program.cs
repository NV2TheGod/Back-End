using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("M. Couillon",15);
            Client client2 = new Client("Misses Debile", 24);
            Console.WriteLine(client1);
            Console.WriteLine(client2);
        }
    }
}