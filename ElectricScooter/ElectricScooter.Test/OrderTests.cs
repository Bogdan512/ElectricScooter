using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ElectricScooter.Test
{
    public class OrderTests
    {
        [Fact]
        public void Return_An_Order()
        {
            var order = new Order(new Rent[]
                {
                    new Rent(2, "Adults", 4),
                    new Rent(2, "Kids", 4),
                });
            string[] expected = { "2 - Adults - 4", "2 - Kids - 4" };
            string[] actual = order.Print();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return_Sum_Of_An_Order_2_Kids_2_Adults_1_Hour()
        {
            var order = new Order(new Rent[]
                {
                    new Rent(2, "Adults", 1),
                    new Rent(2, "Kids", 1)
                });
            decimal actual = order.GetSumOfOrder();
            Assert.Equal(60, actual);
        }

        [Fact]
        public void Return_Sum_Of_An_Order_2_Kids_2_Adults_4_Hours()
        {
            var order = new Order(new Rent[]
                {
                    new Rent(2, "Adults", 4),
                    new Rent(2, "Kids", 4)
                });
            decimal actual = order.GetSumOfOrder();
            Assert.Equal(160, actual);
        }
    }
}
