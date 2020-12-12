using System;
using System.Collections.Generic;

namespace SkiResort
{
    public abstract class SkiShoesBase
    {
        //public List<int> SkiShoesSizes = new List<int>();
        // What is the SHOE? Brand fitype, rentprice values. This answers that
        // What is the size, thats all.
        public List<int> AvailableSkiShoesSizes = new List<int>();
        public SkiShoesBrands Brand { get; }
        public SkiShoesFitType fitType { get; }  
        public double RentPrice { get; }
        public bool isAvailable = true;
        public bool sizeAvailability = true;



        protected SkiShoesBase(SkiShoesBrands Brand, SkiShoesFitType fitType,
            double RentPrice)
        {
            this.fitType = fitType;
            this.Brand = Brand;
            this.RentPrice = RentPrice;
        }

        public void AddSizesToList(int lowerRange, int higherRange)
        {
            for (int i = lowerRange; i<= higherRange; i++)
            {
                //SkiShoesSizes.Add(i);
                AvailableSkiShoesSizes.Add(i);
            }
        }

        public void PrintAvailableShoeSizes()
        {
            AvailableSkiShoesSizes.Sort();
            foreach(int PrintSkiShoes in AvailableSkiShoesSizes)
            {
                Console.WriteLine("**" + PrintSkiShoes + " **");
            }
            
        }

        public abstract void Description();

        
        public bool isSizeAvailable(int Size)
        {
            if (AvailableSkiShoesSizes.Contains(Size)) 
            {
                return true;
            }
            return false;           
        }
        
        public void availSkiShoesSizeCheck()
        {
            //for (int i = 0; i<= AvailableSkiShoesSizes.Count; i ++)
            //{
                
            //}

            foreach (int Object in AvailableSkiShoesSizes)
            {
                Console.Write(Object);
            }
            
        }

        public void listOfShoes()
        {
            foreach (int Object in AvailableSkiShoesSizes)
            {
                Console.Write(Object);
            }
        }



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
