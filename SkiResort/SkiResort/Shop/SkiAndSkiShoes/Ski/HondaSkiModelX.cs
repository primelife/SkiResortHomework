using System;
namespace SkiResort
{
    public class HondaSkiModelX : SkiBase
    {
        public HondaSkiModelX( )
            : base(SkiBrands.Honda, SkiSizes.Medium, SkiExperienceLevel.Beginner, 99.99)
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
