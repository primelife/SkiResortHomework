using System;
using System.Collections.Generic;

namespace SkiResort
{
    public abstract class SkiShoesBase
    {
        //public List<int> SkiShoesSizes = new List<int>();
        // What is the SHOE? Brand fitype, rentprice values. This answers that
        // What is the size, thats all.
        public int ShoeSize { get; }
        public SkiShoesBrands Brand { get; }
        public SkiShoesFitType fitType { get; }  
        public double RentPrice { get; }
        public bool SizeAvailable { get; set; }



    protected SkiShoesBase(SkiShoesBrands Brand,
            SkiShoesFitType fitType,
            double RentPrice,
            int ShoeSize)
        {
            this.fitType = fitType;
            this.Brand = Brand;
            this.RentPrice = RentPrice;
            this.ShoeSize = ShoeSize;
            this.SizeAvailable = true;
        }


        public abstract void Description();


        // How to make abstract class. This gives us the capability
        // to force classes extending SkiShoesBase to give body to
        // any abstract method in SkiShoesBase.

        // public abstract Class SkiShoesBase
        // public abstract void className (); NOTE! No Body, only ext. classes
        // then, in all extending classes need to have code as such:
        // public override className (){Code}. Ext Classes className Code
        // will used for whatever className does. 


        // if the class is abstract and we have the below:
        // we force the classes extending SkiShoeBase to give body to:
        // Description();

    }
}
