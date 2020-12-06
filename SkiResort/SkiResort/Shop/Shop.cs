using System;
using System.Collections.Generic;
namespace SkiResort

{

    public class Shop
    {

        //private List<SkiBase> Ski = new List<SkiBase>();
        private Dictionary<SkiBrands, List<SkiBase>> Ski = new Dictionary<SkiBrands, List<SkiBase>>();
        

        // Constructor
        public Shop()
        {
            initDictionary();
            populateSki();
        }

        private void initDictionary()
        {
            foreach (SkiBrands skiBrand in Enum.GetValues(typeof(SkiBrands)))
            {
                Ski[skiBrand] = new List<SkiBase>();
            }
        }


        private void populateSki()
        {
            //add to the shop all the available ski
            AddSki(new HondaSkiModelX());
        }

        private void populateSkiShoes()
        {
            for(int i = 35; i < 46; i++)
            {
                // add to dictionary new skie shoe model with size i
            }
        }



        private void AddSki(SkiBase inputSki)
        {
            Ski[inputSki.Brand].Add(inputSki);
        }

        public void AddSKiShoes(string Brand, double RentPrice, string SkiShoeSize, int Type) //redo
        {

        }

        public void Rent(SkiBrands Brand, SkiSizes Size)
        {


            foreach (SkiBase ski in Ski[Brand])
            {
                if (ski.Brand == Brand & ski.SkiSize == Size)
                {
                    ski.isAvailable = false;
                    Console.WriteLine("You've rented Ski " + Brand + " Size: " + Size);
                    return;
                }

                
            }
            Console.WriteLine("There is no item with Brand: " + Brand + " and Size: " + Size);
        }

        public void Return(SkiBrands Brand, SkiSizes Size)
        {
            foreach (SkiBase ski in Ski[Brand])
            {
                if (ski.Brand == Brand & ski.SkiSize == Size)
                {
                    ski.isAvailable = true;
                    Console.WriteLine("You've return Ski " + Brand + " Size: " + Size);
                    return;
                }


            }
            Console.WriteLine("There is no item with Brand: " + Brand + " and Size: " + Size);
        }

        public void listAvailableSki()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Ski List:");
            foreach (SkiBrands skiBrand in Ski.Keys)
            {
                foreach (SkiBase ski in Ski[skiBrand])
                {
                    if(ski.isAvailable) printSkiInfo(ski);
                }
            }

        }

        public void listFullSkiList()
        {
        Console.WriteLine("-----------");
        Console.WriteLine("Ski List:");
            foreach (SkiBrands skiBrand in Ski.Keys)
            {
                foreach(SkiBase ski in Ski[skiBrand])
                {
                    printSkiInfo(ski);
                }
            }
   
        }

        private void printSkiInfo(SkiBase ski)
        {
            Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
        }
    }
}



    

