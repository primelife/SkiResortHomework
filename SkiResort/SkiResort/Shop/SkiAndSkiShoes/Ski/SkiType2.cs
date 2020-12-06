using System;
namespace SkiResort.SkiResort.Shop.Base.Ski
{
    public class SkiType2 : SkiBase
    {
        private int dangerLevel { get; }

        public SkiType2(string Brand, double RentPrice, string SkiSize, int Type, int dangerLeve)
            : base(Brand, RentPrice, SkiSize, Type)
        {
            this.dangerLevel = dangerLevel;

        }


    }
}
