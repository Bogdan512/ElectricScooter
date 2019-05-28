using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricScooter
{
    public class Scooter
    {
        int kg;

        public Scooter(int kg)
        {
            this.kg = kg;
        }

        public string Print()
        {
            return kg <= 35 ? "Child" : "Adult";
        }
    }
}
