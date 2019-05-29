using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricScooter
{
    public class Scooter
    {
        int nrOfScooters;
        string typeOfScooters;
        int nrOfHours;

        public Scooter(int nrOfScooters, string typeOfScooters, int nrOfHours)
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
