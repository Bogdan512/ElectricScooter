using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricScooter
{
    public class Payment
    {
        decimal hourlyCostAdults = 20;
        decimal hourlyCostKids = 10;
        decimal fourHourCostAdults = 50;
        decimal fourHourCostkids = 30;
        decimal fullDayCostAdults = 150;
        decimal fullDayCostKids = 100;

        public decimal GetHourlyCost(TypeOfScooters adultOrKid)
        {
            return adultOrKid == TypeOfScooters.Adults ? 20 : 10;
        }

        public decimal GetFourHourCost(TypeOfScooters adultOrKid)
        {
            return adultOrKid == TypeOfScooters.Adults ? 50 : 30;
        }

        public decimal GetFullDayCost(TypeOfScooters adultOrKid)
        {
            return adultOrKid == TypeOfScooters.Adults ? 150 : 100;
        }
    }
}
