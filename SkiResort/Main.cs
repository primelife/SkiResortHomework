using System;
using System.Collections.Generic;

namespace SkiResort
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Clear();

            SkiVillage Bansko = new SkiVillage();
            
            VisitorBase john = new VisitorBase(16,"John");
            VisitorBase mary = new VisitorBase(50,"Mary");


            // User rentind capabilities for Ski and Shoes.

            Bansko.listFullSkiList();
            Bansko.RentSki(john, SkiBrands.Honda, SkiSizes.Medium);
            Bansko.RentSkiShoes(john, SkiShoesBrands.Fischer, 36);
            Bansko.UserRentedEquipment(john);
            Bansko.ReturnSki(john);
            Bansko.ReturnSkiShoes(john);
            Bansko.UserRentedEquipment(john);

            //Bansko.SlopesInfo();


            //Buying and Using SLides Capabilities;
            Bansko.BuySlides(john, SlopeName.Balkaniada, 10);
            Bansko.PrintPistCapacity(SlopeName.Balkaniada);
            Bansko.PrintPistCapacity(SlopeName.Balkaniada);

            Bansko.UseAvailableSlides(john, SlopeName.Balkaniada);

            Bansko.PrintRentedEquipmentDurability(john);
            Bansko.PrintPistCapacity(SlopeName.Balkaniada);
            // i need reference by type for printpistcapacity  so I can get real - time slide capacity otherwise it doesnt work





        }



        //skishop.RentSki(SkiBrands.Skoda, SkiSizes.Medium);



        //Bansko.VisitorsInfo();
        //John john = new John();

        //Console.WriteLine(Bansko.getVisitorsCollevtion().Count);

        //Bansko.skiShop.RentSki(John, SkiBrands.Honda, SkiSizes.Large);




        // Ski functionality
        //---------------------------------------------------

        //SkiShop.SkiDescription(SkiBrands.Honda);
        //SkiShop.RentSki(SkiBrands.Honda, SkiSizes.Medium);
        //SkiShop.listFullSkiList();
        //SkiShop.ReturnSki(SkiBrandsHonda, SkiSizes.Medium);
        //SkiShop.listFullSkiList();

        //---------------------------------------------------

        // SkiShoes functionality
        //---------------------------------------------------

        //skiShop.listFullSkiShoesList();
        //SkiShop.SkiShoesDescription(SkiShoesBrands.Fischer);
        //SkiShop.RentSkiShoes(SkiShoesBrands.Fischer, 36);
        //SkiShop.listFullSkiShoesList();
        //SkiShop.ReturnSkiShoes(SkiShoesBrands.Fischer, 36);
        //SkiShop.listAvailableShoeSizes(SkiShoesBrands.Fischer);

        //---------------------------------------------------




        // WHAT IS REFENRECE AGAIN? (reference and pointer stuff)
        // REFERENCE AND POINTER. Bansko Stack, new SkiVillage in HEAP
        // You cannot create Bansko unless it refference to a Space in the Heap.
        // 
        /* HomeWork. Dec 15   SHOW ME BUILDER NEXT TIME (TO NIKI)
         * 1. Create Human? Create user. Resort visitor. (DONE)
         * 3. We should have 3 different types of Slopes. Ski Slopes (types of difficulty)DONE
         * 6. We have multiple Humans(DONE)
         * 4. This Human (visitor) cannot exceed the limit of humans per Slope. (Done)
         * 5. Each Slope costs money. Takes money per Slide. User needs to pay for 
         * every trip up the slope. (ROUGHLY DONE)
         * 2. This Human should be able to use the Shop Class func. (DONE)
         * 
         * 
         * 2.1 When humans rents Ski he gets a reference to the ski and shoes
         * he loaned. **************** (DONE)
         * 
         * 

         * 
         * 
         * 

         * 
         * Create object that controls the slopes. Bob uses this object

        */


    }
}


