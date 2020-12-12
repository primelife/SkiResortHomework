using System;
namespace SkiResort
{
    public class YamahaSkiModelZ : SkiBase
    {
        public YamahaSkiModelZ()
            : base(SkiBrands.Yamaha, SkiSizes.Large, SkiExperienceLevel.Intermediate, 499.99)
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
