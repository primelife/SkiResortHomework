using System;
using System.Collections.Generic;

namespace SkiResort
{
    public class FischerShoesModelS : SkiShoesBase
    {

        public FischerShoesModelS(int ShoeSize)
         : base(SkiShoesBrands.Fischer, SkiShoesFitType.Race, 199.99, ShoeSize)
        {        }

        public override void Description()
        {
               Console.WriteLine("--------");
               Console.WriteLine("This is Model: " + Brand + " " +
                "has fitType: " +
                fitType + ". RentPrice is: " + RentPrice);
        }

}
    
}
