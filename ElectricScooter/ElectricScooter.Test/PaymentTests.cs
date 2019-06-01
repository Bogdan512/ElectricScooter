using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ElectricScooter.Test
{
    public class PaymentTests
    {
        [Fact]
        public void Should_Return_One_Hour_Cost_Kids_1_Scooter()
        {
            Payment payment = new Payment();
            decimal actual = payment.GetHourlyCost(TypeOfScooters.Kids);
            Assert.Equal(10, actual);
        }

        [Fact]
        public void Should_Return_Four_Hour_Cost_Kids_1_Scooter()
        {
            Payment payment = new Payment();
            decimal actual = payment.GetFourHourCost(TypeOfScooters.Kids);
            Assert.Equal(30, actual);
        }

        [Fact]
        public void Should_Return_FullDay_Cost_Kids_1_Scooter()
        {
            Payment payment = new Payment();
            decimal actual = payment.GetFullDayCost(TypeOfScooters.Kids);
            Assert.Equal(100, actual);
        }

        [Fact]
        public void Should_Return_One_Hour_Cost_Adults_1_Scooter()
        {
            Payment payment = new Payment();
            decimal actual = payment.GetHourlyCost(TypeOfScooters.Adults);
            Assert.Equal(20, actual);
        }

        [Fact]
        public void Should_Return_Four_Hour_Cost_Adults_1_Scooter()
        {
            Payment payment = new Payment();
            decimal actual = payment.GetFourHourCost(TypeOfScooters.Adults);
            Assert.Equal(50, actual);
        }

        [Fact]
        public void Should_Return_FullDay_Cost_Adults_1_Scooter()
        {
            Payment payment = new Payment();
            decimal actual = payment.GetFullDayCost(TypeOfScooters.Adults);
            Assert.Equal(150, actual);
        }
    }
}
