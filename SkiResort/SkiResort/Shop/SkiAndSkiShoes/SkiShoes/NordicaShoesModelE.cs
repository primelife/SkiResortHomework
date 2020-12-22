using System;

namespace SkiResort
{
    public class NordicaShoesModelE : SkiShoesBase
    {
        public NordicaShoesModelE(int ShoeSize)
         : base(SkiShoesBrands.Nordica, SkiShoesFitType.Touring, 499.99, ShoeSize)
        {
        }

        public override void Description()
        {
            Console.WriteLine("--------");
            Console.WriteLine("This is Model: " + Brand + " " +
                "has fitType: " +
                fitType + ". RentPrice is: " + RentPrice + " Size: " + ShoeSize
                + " availability: " + SizeAvailable);
        }
    }
}
