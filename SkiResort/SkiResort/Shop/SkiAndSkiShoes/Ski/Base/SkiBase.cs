using System;
namespace SkiResort
{
    public class SkiBase
    {
        public SkiExperienceLevel ExperienceLevel { get; }
        public SkiBrands Brand { get; }
        public SkiSizes SkiSize { get; }
        public double RentPrice { get; }
        public bool isAvailable = true;
        public int Durability = 100;

        protected SkiBase(SkiBrands Brand, SkiSizes SkiSize, SkiExperienceLevel ExperienceLevel, double RentPrice)

        {
            this.ExperienceLevel = ExperienceLevel;
            this.Brand = Brand;
            this.RentPrice = RentPrice;
            this.SkiSize = SkiSize;
        }


        //all classes extending SkiBase will use this method
        //unless the current implementation has an override

        // The way to write this is:

        // public virtual void methodName
        // ovveride public void methodName (in extending class)
        public virtual void Description()
        {
            Console.WriteLine("This is Model: " + Brand + "with Size: " +
                SkiSize + ". Level is: " + ExperienceLevel + " price: + " +
                RentPrice);
        }

        public void PrintAvailability()
        {
            if (isAvailable)
            {
                Console.WriteLine("*Item: " + Brand + "* (Size: " + SkiSize + ") is available");
                return;
            }
            Console.WriteLine(" Item: " + Brand + "(Size: " + SkiSize + ") is not available ");
        }

        public void reCalcDurability(slopeBase slope, int slides)
        {
                
            

            if (slope.pistDurabilityCost == slopeDurabilityCost.low)
            {
                Durability = Durability - 10 * slides;
                Console.WriteLine("Reduced Durability by " + 10 * slides);
                recalcAvailability();
                return;
            }
            else if (slope.pistDurabilityCost == slopeDurabilityCost.mid)
            {
                Durability = Durability - 20 * slides;
                Console.WriteLine("Reduced Durability by " + 20 * slides);
                recalcAvailability();
                return;
           
            }
                Durability = Durability - 30 * slides;
            Console.WriteLine("Reduced Durability by " + 30 * slides);

                recalcAvailability();
                return;
            }

        private void recalcAvailability()
        {
            if (Durability == 0)
            {
                isAvailable = false;
            }
        }


    }
}    
    

