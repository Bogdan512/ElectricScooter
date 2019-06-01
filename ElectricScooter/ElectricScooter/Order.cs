using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricScooter
{
     public class Order
    {
       Rent[] rents;

        public Order(Rent[] rents)
        {
            this.rents = rents;
        }
        
        public string[] Print()
        {
            string[] result = new string[rents.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rents[i].Print();
            }
            return result;
        }

        public decimal GetSumOfOrder()
        {
            decimal result = 0;
            for (int i = 0; i < rents.Length; i++)
            {
                result += rents[i].CaluclateOrder(rents[i]);
            }
            return result;
        }
    }
}
