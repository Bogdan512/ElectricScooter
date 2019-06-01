using System;

namespace ElectricScooter
{
    class Program
    {
        static void Main(string[] args)
        {
            Rent rent = new Rent(1, TypeOfScooters.Kids, 4);
            decimal actual = rent.GetPrice();
            Console.WriteLine(actual);

            //var order = new Order(new Rent[]
            //    {
            //        new Rent(2, "Adults", 4),
            //        new Rent(2, "Kids", 4)
            //    });
            //decimal actual = order.GetSumOfOrder();

            Console.Read();
        }
    }
}
