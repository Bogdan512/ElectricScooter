using System;

namespace ElectricScooter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rent rent = new Rent(1, "Kids", 1);
            //decimal actual = rent.GetHourlyCostKids();
            //Console.WriteLine(actual);

            var order = new Order(new Rent[]
                {
                    new Rent(2, "Adults", 4),
                    new Rent(2, "Kids", 4)
                });
            decimal actual = order.GetSumOfOrder();

            Console.Read();
        }
    }
}
