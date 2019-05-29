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
            string[] expected = {"2 - Adults - 4", "2 - Kids - 4" };
            string[] actual = order.Print();
            Assert.Equal(expected, actual);
        }
    }
}
