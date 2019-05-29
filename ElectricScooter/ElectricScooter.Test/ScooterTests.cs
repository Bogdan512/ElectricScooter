using System;
using Xunit;

namespace ElectricScooter
{
    public class ScooterTests
    {
        [Fact]
        public void Should_Return_Nrs_Of_Scooters_The_Type_And_Hours()
        {
            var scooters = new Scooter(2, "Adult", 4);
            string actual = scooters.Print();
            Assert.Equal("2 - Adult - 4", actual);
        }
    }
}
