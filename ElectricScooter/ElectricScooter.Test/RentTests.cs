using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ElectricScooter.Test
{

    public class RentTests
    {
        [Fact]
        public void Should_Return_One_Hour_Cost_Kids_1_Scooter()
        {
            Rent rent = new Rent(1, TypeOfScooters.Kids, 1);
            decimal actual = rent.GetPrice();
            Assert.Equal(10, actual);
        }

        [Fact]
        public void Should_Return_Four_Hour_Cost_Kids_1_Scooter()
        {
            Rent rent = new Rent(1, TypeOfScooters.Kids, 4);
            decimal actual = rent.GetPrice();
            Assert.Equal(30, actual);
        }

        [Fact]
        public void Should_Return_FullDay_Cost_Kids_1_Scooter()
        {
            Rent rent = new Rent(1, TypeOfScooters.Kids, 24);
            decimal actual = rent.GetPrice();
            Assert.Equal(100, actual);
        }

        [Fact]
        public void Should_Return_One_Hour_Cost_Adults_1_Scooter()
        {
            Rent rent = new Rent(1, TypeOfScooters.Adults, 1);
            decimal actual = rent.GetPrice();
            Assert.Equal(20, actual);
        }

        [Fact]
        public void Should_Return_Four_Hour_Cost_Adults_1_Scooter()
        {
            Rent rent = new Rent(1, TypeOfScooters.Adults, 4);
            decimal actual = rent.GetPrice();
            Assert.Equal(50, actual);
        }

        [Fact]
        public void Should_Return_FullDay_Cost_Adults_1_Scooter()
        {
            Rent rent = new Rent(1, TypeOfScooters.Adults, 24);
            decimal actual = rent.GetPrice();
            Assert.Equal(150, actual);
        }
    }
}
