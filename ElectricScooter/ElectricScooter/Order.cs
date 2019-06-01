using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricScooter
{
     public class Order
    {
       Rent[] rent;

        public Order(Rent[] rent)
        {
            this.rent = rent;
        }
        
        //public string[] Print()
        //{
        //    string[] result = new string[rent.Length];
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        result[i] = rent[i].Print();
        //    }
        //    return result;
        //}
    }
}
