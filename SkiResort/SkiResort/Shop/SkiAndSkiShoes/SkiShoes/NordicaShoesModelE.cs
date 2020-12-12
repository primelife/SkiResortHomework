using System;
namespace SkiResort
{
    public class NordicaShoesModelE : SkiShoesBase
    {
        private int lowerRange { get; }
        private int higherRange { get; }

        public NordicaShoesModelE(int lowerSizeRange, int higherSizeRange)
         : base(SkiShoesBrands.Nordica, SkiShoesFitType.Touring, 499.99)
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
