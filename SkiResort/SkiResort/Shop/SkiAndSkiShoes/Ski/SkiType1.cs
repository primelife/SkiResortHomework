using System;
namespace SkiResort.SkiResort.Shop.Base.Ski
{
    public class SkiType1 : SkiBase
    {

        public int dangerLevel { get; }
      

        public SkiType1(string Brand, double RentPrice, string SkiSize, int Type, int dangerLevel)
            : base(Brand, RentPrice, SkiSize, Type)
        {

            this.dangerLevel = dangerLevel;
        }


    }
}
