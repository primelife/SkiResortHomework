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
                Console.WriteLine(" Item: " + Brand + "(Size: " + SkiSize + ") is available");
                return;
            }
            Console.WriteLine(" Item: " + Brand + "(Size: " + SkiSize + ") is not available ");
        }

    }
    
}
