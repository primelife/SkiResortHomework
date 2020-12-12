using System;
using System.Collections.Generic;


namespace SkiResort
{
    public class SkiVillage
    {
        private List<Shop> Shop = new List<Shop>();

        public SkiVillage()
        {
                   
        }

        public void addShop(Shop shop)

        {           
            Shop.Add(shop);
        }

 
        // Fix



        //public void Rent(string Brand, string Size)
        //{

        //    //foreach(Shop shop in Shop)
        //    //{
        //    //    shop.Rent(Brand, Size);
        //    //}
            
        //}

        //public void Return(string Brand, string Size)
        //{

        //    //foreach (Shop shop in Shop)
        //    //{
        //    //    shop.Return(Brand, Size);
        //    //}

        //}





    }
}
