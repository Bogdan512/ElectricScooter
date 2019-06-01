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
        Order order;

        public Rent(int nrOfScooters, string typeOfScooters, int nrOfHours)
        {
            this.nrOfScooters = nrOfScooters;
            this.typeOfScooters = typeOfScooters;
            this.nrOfHours = nrOfHours;
        }

        public string Print()
        {
            return $"{nrOfScooters} - {typeOfScooters} - {nrOfHours}"; 
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

        public decimal CaluclateOrder(Rent rent)
        {
            decimal result = 0;
            if(rent.typeOfScooters == "Adults" && rent.nrOfHours == 1)
            {
                result = rent.nrOfScooters * GetHourlyCostAdults();
            }

            if (rent.typeOfScooters == "Kids" && rent.nrOfHours == 1)
            {
                result = rent.nrOfScooters * GetHourlyCostKids();
            }

            if (rent.typeOfScooters == "Adults" && rent.nrOfHours == 4)
            {
                result = rent.nrOfScooters * GetFourHourCostAdults();
            }

            if (rent.typeOfScooters == "Kids" && rent.nrOfHours == 4)
            {
                result = rent.nrOfScooters * GetFourHourCostKids();
            }
            return result;
        }

    }
}
