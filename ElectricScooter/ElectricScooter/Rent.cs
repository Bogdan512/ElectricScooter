using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricScooter
{
    public class Rent
    {
        int nrOfScooters;
        string typeOfScooters;
        int nrOfHours;
        Payment payment = new Payment();

        public Rent(int nrOfScooters, string typeOfScooters, int nrOfHours)
        {
            this.nrOfScooters = nrOfScooters;
            this.typeOfScooters = typeOfScooters;
            this.nrOfHours = nrOfHours;
        }


        public decimal GetHourlyCostKids()
        {
            decimal result = payment.GetHourlyCost("Kids");
            return result;
        }

        public decimal GetFourHourCostKids()
        {
            decimal result = payment.GetFourHourCost("Kids");
            return result;
        }

        public decimal GetFullDayCostKids()
        {
            decimal result = payment.GetFullDayCost("Kids");
            return result;
        }

        public decimal GetHourlyCostAdults()
        {
            decimal result = payment.GetHourlyCost("Adults");
            return result;
        }

        public decimal GetFourHourCostAdults()
        {
            decimal result = payment.GetFourHourCost("Adults");
            return result;
        }

        public decimal GetFullDayCostAdults()
        {
            decimal result = payment.GetFullDayCost("Adults");
            return result;
        }
    }
}
