using System;

namespace SkiResort
{
    public class SalomonShoesModelY : SkiShoesBase
    {

        public SalomonShoesModelY(int ShoeSize)
         : base(SkiShoesBrands.Salomon, SkiShoesFitType.Race, 269.99, ShoeSize)
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
