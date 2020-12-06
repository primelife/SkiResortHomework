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


            // We created Ski1 of Type 1                
            SkiType1 Ski11 = new SkiType1("Yamaha", 49.99, "Small", 1, 5);
            SkiType1 Ski12 = new SkiType1("Yamaha", 49.99, "Medium", 1, 5);
            SkiType1 Ski13 = new SkiType1("Yamaha", 49.99, "Large", 1, 5);

            SkiType2 Ski21 = new SkiType2("Skoda", 59.99, "Small", 2, 7);
            SkiType2 Ski22 = new SkiType2("Skoda", 59.99, "Medium", 2, 7);
            SkiType2 Ski23 = new SkiType2("Skoda", 59.99, "Large", 2, 7);

            SkiType3 Ski31 = new SkiType3("Suzuki", 69.99, "Small", 3, 3);
            SkiType3 Ski32 = new SkiType3("Suzuki", 69.99, "Medium", 3, 3);
            SkiType3 Ski33 = new SkiType3("Suzuki", 69.99, "Large", 3, 3);

            SkiType4 Ski41 = new SkiType4("Honda", 79.99, "Small", 4, 9);
            SkiType4 Ski42 = new SkiType4("Honda", 79.99, "Medium", 4, 9);
            SkiType4 Ski43 = new SkiType4("Honda", 79.99, "Large", 4, 9);

            SkiType5 Ski51 = new SkiType5("Toyota", 89.99, "Small", 5, 4);
            SkiType5 Ski52 = new SkiType5("Toyota", 89.99, "Medium", 5, 4);
            SkiType5 Ski53 = new SkiType5("Toyota", 89.99, "Large", 5, 4);
            SkiShop.AddSki(Ski11);
            SkiShop.AddSki(Ski12);
            SkiShop.AddSki(Ski13);
            SkiShop.AddSki(Ski21);
            SkiShop.AddSki(Ski22);
            SkiShop.AddSki(Ski23);
            SkiShop.AddSki(Ski31);
            SkiShop.AddSki(Ski32);
            SkiShop.AddSki(Ski33);
            SkiShop.AddSki(Ski41);
            SkiShop.AddSki(Ski42);
            SkiShop.AddSki(Ski43);
            SkiShop.AddSki(Ski51);
            SkiShop.AddSki(Ski52);
            SkiShop.AddSki(Ski53);

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



            {

        }

          

        }
    }
}
