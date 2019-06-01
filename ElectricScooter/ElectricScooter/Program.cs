using System;

namespace ElectricScooter
{
    class Program
    {
        static void Main(string[] args)
        {
            Rent rent = new Rent(1, "Kids", 1);
            decimal actual = rent.GetHourlyCostKids();
            Console.WriteLine(actual);

            Console.Read();
        }
    }
}
