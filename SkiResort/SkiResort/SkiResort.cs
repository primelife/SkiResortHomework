using System;
using System.Collections.Generic;
using SkiResort.SkiResort.Shop.Base.Ski;


namespace SkiResort
{
    public class SkiVillage
    {
        private List<Shop> Shop = new List<Shop>();
        // Constructor
        public SkiVillage()
        {
           
           

        }

        public void addShop(Shop shop)

        {
           
            Shop.Add(shop);
        }

 


        public void Rent(string Brand, string Size)
        {

            foreach(Shop shop in Shop)
            {
                shop.Rent(Brand, Size);
            }
            
        }

        public void Return(string Brand, string Size)
        {

            foreach (Shop shop in Shop)
            {
                shop.Return(Brand, Size);
            }

        }





    }
}
