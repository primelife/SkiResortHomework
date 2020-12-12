using System;
using System.Collections.Generic;

namespace SkiResort
{
    public class FischerShoesModelS : SkiShoesBase
    {
        private int lowerRange { get; }
        private int higherRange { get; }
        private List<int> sizeList = new List<int>(0);

        public FischerShoesModelS(int lowerSizeRange, int higherSizeRange)
         : base(SkiShoesBrands.Fischer, SkiShoesFitType.Race, 199.99)
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
