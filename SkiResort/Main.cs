using System;
using System.Collections.Generic;

namespace SkiResort
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Clear();
            //SkiShop.listAvailableShoeSizes(SkiShoesBrands.Fischer);

            SkiVillage Bansko = new SkiVillage();
            Shop SkiShop = new Shop();
            Bansko.addShop(SkiShop);

            // Ski rentring and returning capabilies
            // Ski Description and Availability display commands.

            //---------------------------------------------------

            //SkiShop.listFullSkiList();
            //SkiShop.SkiDescription(SkiBrands.Honda);
            //SkiShop.RentSki(SkiBrands.Honda, SkiSizes.Medium);
            //SkiShop.listFullSkiList();
            //SkiShop.ReturnSki(SkiBrands.Honda, SkiSizes.Medium);
            //SkiShop.listFullSkiList();

            //---------------------------------------------------

            //---------------------------------------------------

            SkiShop.listFullSkiShoesList();
            SkiShop.SkiShoesDescription(SkiShoesBrands.Fischer);
            SkiShop.RentSkiShoes(SkiShoesBrands.Fischer, 39);
            SkiShop.listAvailableShoeSizes(SkiShoesBrands.Fischer);
            SkiShop.ReturnSkiShoes(SkiShoesBrands.Fischer, 39);
            SkiShop.listAvailableShoeSizes(SkiShoesBrands.Fischer);

            //---------------------------------------------------

            //SkiShop.RentSkiShoes(SkiShoesBrands.Fischer, 42);
            //SkiShop.listFullSkiShoesList();
            //SkiShop.ReturnSkiShoes(SkiShoesBrands.Fischer, 42);
            //SkiShop.listFullSkiShoesList();




            // Homework:
            // 1. Ski Resort - They offer SKI and SKI shoes
            //    - SKIs have: Brand, Rent Price, Size/Length
            //    - Shoes have: Brand, Rent Price, Size/Length
            // 2. Resort offers:
            //    - 5 types of SKI with 3 sets of each type. (15 total)
            //    - 4 types of SKI shoes with 2 sets of each shoe size from 35 - 45
            // 3. Rent SKI, Shoes or Both
            // 4. Return SKI, Shoes or Both





            //SkiShop.listFullSkiList();

            //Bansko.Rent("Honda", "Large");
            //SkiShop.listAvailableSki();
            //Bansko.Return("Honda", "Large");
            //SkiShop.listAvailableShoeSizes(SkiShoesBrands.Fischer);
            // Types can be from 1-5;
            // 1. Showblades (danger level 5)
            // 2. FreeRide
            // 3. Racing
            // 4. FreeStyle
            // 5. Carving

            // Danger can be from 1-10. This is what makes different types of SKi different.



            // Select a your choice and populate it's number in "Type"




            //Dictionary<int, string> simpleDictionary = new Dictionary<int, string>();






            ////simpleDictionary.Add(1, "hello");

            ////simpleDictionary.Get(1); // hello



            ////simpleDictionary[1] = "";
            ////string getString = simpleDictionary[1];\




            // Homework
            // make code pretty
            // fix rent, return, print descriptions, check availability methods
            // 


            // How to crate SkiShoes (figure out sizes dynamically)
            // When renting figure get(Brand, ShoeSize)

        }
    }
}
