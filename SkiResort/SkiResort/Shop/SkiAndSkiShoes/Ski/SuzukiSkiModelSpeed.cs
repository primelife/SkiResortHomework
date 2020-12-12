using System;
namespace SkiResort
{
    public class SuzukiSkiModelSpeed : SkiBase
    {
        public SuzukiSkiModelSpeed()
            : base(SkiBrands.Suzuki, SkiSizes.Short, SkiExperienceLevel.Beginner, 49.99)
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
