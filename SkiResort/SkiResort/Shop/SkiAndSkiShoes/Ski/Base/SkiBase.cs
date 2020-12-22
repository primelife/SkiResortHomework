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
        private int Durability = 100;

        protected SkiBase(SkiBrands Brand, SkiSizes SkiSize, SkiExperienceLevel ExperienceLevel, double RentPrice)

        {
            this.ExperienceLevel = ExperienceLevel;
            this.Brand = Brand;
            this.RentPrice = RentPrice;
            this.SkiSize = SkiSize;
        }


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

        public void reduceDurability(int creditDurability)
        {
            Durability -= creditDurability;
            Console.WriteLine("Reduced Durability by " + creditDurability);
            recalcAvailability();
        }

        public int getDurability()
        {
            return Durability;
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
    

