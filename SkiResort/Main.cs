using System;
using System.Collections.Generic;
using SkiResort.SkiResort.Shop.Base.Ski;

namespace SkiResort
{
    class Program

    {
        static void Main(string[] args)
        {

            // Homework:
            // 1. Ski Resort - They offer SKI and SKI shoes
            //    - SKIs have: Brand, Rent Price, Size/Length
            //    - Shoes have: Brand, Rent Price, Size/Length
            // 2. Resort offers:
            //    - 5 types of SKI with 3 sets of each type. (15 total)
            //    - 4 types of SKI shoes with 2 sets of each shoe size from 35 - 45
            // 3. Rent SKI, Shoes or Both
            // 4. Return SKI, Shoes or Both

            

            // We create the SkiResort
            SkiVillage Bansko = new SkiVillage();

            // Then we create the Shop (I made a mistake with how i connected my classes here. Ski resort and Shop)
            Shop SkiShop = new Shop();
            Bansko.addShop(SkiShop);
            

            SkiShop.listFullSkiList();

            Bansko.Rent("Honda", "Large");
            SkiShop.listAvailableSki();
            Bansko.Return("Honda", "Large");

            // Types can be from 1-5;
            // 1. Showblades (danger level 5)
            // 2. FreeRide
            // 3. Racing
            // 4. FreeStyle
            // 5. Carving

            // Danger can be from 1-10. This is what makes different types of SKi different.



            // Select a your choice and populate it's number in "Type"


            Dictionary<int, string> simpleDictionary = new Dictionary<int, string>();


            //simpleDictionary.Add(1, "hello");

            //simpleDictionary.Get(1); // hello


            
            //simpleDictionary[1] = "";
            //string getString = simpleDictionary[1];

        }
    }
}
