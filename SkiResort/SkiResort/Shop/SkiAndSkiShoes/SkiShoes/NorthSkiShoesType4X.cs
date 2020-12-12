using System;
namespace SkiResort
{
    public class NorthSkiShoesType4X : SkiShoesBase
    {
        private int lowerRange { get; }
        private int higherRange { get; }

        public NorthSkiShoesType4X(int lowerSizeRange, int higherSizeRange)
         : base(SkiShoesBrands.North, SkiShoesFitType.Touring, 1499.99)
        {
            this.lowerRange = lowerSizeRange;
            this.higherRange = higherSizeRange;
            addSizes();
        }

        public void addSizes()
        {
            AddSizesToList(lowerRange, higherRange);
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
