using System;
namespace SkiResort
{
    public class SkiBase
    {

        public string Brand { get; }
        public string SkiSize { get; }
        public double RentPrice { get; }
        public int Type { get; }
        public bool isAvailable = true;



        public SkiBase(string Brand, double RentPrice, string SkiSize, int Type)
        {

            this.Brand = Brand;
            this.RentPrice = RentPrice;
            this.SkiSize = SkiSize;
            this.Type = Type;
        }

    }
    
}
