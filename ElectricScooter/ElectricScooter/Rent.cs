using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricScooter
{
    public enum TypeOfScooters { Adults, Kids };
    public class Rent
    {
        int nrOfScooters;
        TypeOfScooters typeOfScooters;
        int nrOfHours;
        Payment payment = new Payment();

        

        public Rent(int nrOfScooters, TypeOfScooters typeOfScooters, int nrOfHours)
        {
            this.nrOfScooters = nrOfScooters;
            this.typeOfScooters = typeOfScooters;
            this.nrOfHours = nrOfHours;
        }

        public string Print()
        {
            return $"{nrOfScooters} - {typeOfScooters} - {nrOfHours}"; 
        }

        public decimal GetPrice()
        {
            decimal result = 0;
            if(typeOfScooters == TypeOfScooters.Adults && nrOfHours == 1)
            {
                return nrOfScooters * payment.GetHourlyCost(TypeOfScooters.Adults);
            }

            if (typeOfScooters == TypeOfScooters.Kids && nrOfHours == 1)
            {
                return nrOfScooters * payment.GetHourlyCost(TypeOfScooters.Kids);
            }

            if (typeOfScooters == TypeOfScooters.Adults && nrOfHours == 4)
            {
                return nrOfScooters * payment.GetFourHourCost(TypeOfScooters.Adults);
            }

            if (typeOfScooters == TypeOfScooters.Kids && nrOfHours == 4)
            {
                return nrOfScooters * payment.GetFourHourCost(TypeOfScooters.Kids);
            }

            if (typeOfScooters == TypeOfScooters.Adults && nrOfHours == 24)
            {
                return nrOfScooters * payment.GetFullDayCost(TypeOfScooters.Adults);
            }

            if (typeOfScooters == TypeOfScooters.Kids && nrOfHours == 24)
            {
                return nrOfScooters * payment.GetFullDayCost(TypeOfScooters.Kids);
            }
            return result;
        }

    }
}
