using System;
namespace SkiResort.SkiResort.Shop.Base.Ski
{
    public class SkiType4 : SkiBase
    {

        private int dangerLevel { get; }

        public SkiType4(string Brand, double RentPrice, string SkiSize, int Type, int dangerLevel)
            : base(Brand, RentPrice, SkiSize, Type)
        {
            this.dangerLevel = dangerLevel;

        }


    }
}
