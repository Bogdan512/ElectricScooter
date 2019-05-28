using System;
using Xunit;

namespace ElectricScooter
{
    public class ScooterTests
    {
        [Fact]
        public void Should_Return_The_Type_OF_Scooter_Depending_Of_The_Persons_Weight()
        {
            Scooter scooter = new Scooter(70);
            string actual = scooter.Print();
            Assert.Equal("Adult", actual);
        }
    }
}
