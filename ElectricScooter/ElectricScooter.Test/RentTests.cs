using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ElectricScooter.Test
{
    public class RentTests
    {
        [Fact]
        public void Should_Return_An_Order()
        {
            var rent = new Rent(2, "Adults", 4);

            string actual = rent.Print();
            string expected = "2 - Adults - 4";
            Assert.Equal(expected, actual);
        }
    }
}
