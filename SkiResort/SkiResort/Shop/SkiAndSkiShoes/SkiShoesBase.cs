using System;
namespace SkiResort
{
    public class SkiShoesBase
    {

        public string Brand { get; }
        public string SkiShoesSize { get; }
        public double RentPrice { get; }
        public int Type { get;  }
        public bool isAvailable = true;



        public SkiShoesBase(string Brand, double RentPrice, string SkiShoesSize, int Type)
        {

            this.Brand = Brand;
            this.RentPrice = RentPrice;
            this.SkiShoesSize = SkiShoesSize;
            this.Type = Type;
        }
    }
}
