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
    }
}
