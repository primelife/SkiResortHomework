using System;
namespace SkiResort
{
    public class ToyotaSkiModelW : SkiBase
    {
        public ToyotaSkiModelW()
            : base(SkiBrands.Toyota, SkiSizes.Medium, SkiExperienceLevel.Advanced, 299.99)
        {

        }

        override
        public void Description()
        {
            Console.WriteLine("This is Model: " + Brand + " with Size: " +
                SkiSize + ". Level is: " + ExperienceLevel + " price: " +
                RentPrice);
        }

    }
}
