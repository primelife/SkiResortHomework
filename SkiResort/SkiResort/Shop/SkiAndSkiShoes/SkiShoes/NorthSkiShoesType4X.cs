using System;
namespace SkiResort
{
    public class NorthSkiShoesType4X : SkiShoesBase
    {
        public NorthSkiShoesType4X(int ShoeSize)
         : base(SkiShoesBrands.North, SkiShoesFitType.Touring, 1499.99, ShoeSize)
        {
        }

        public override void Description()
        {
            Console.WriteLine("--------");
            Console.WriteLine("This is Model: " + Brand + " " +
                "has fitType: " +
                fitType + ". RentPrice is: " + RentPrice);
        }
    }
}
