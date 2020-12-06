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

    }
    
}
