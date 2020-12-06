using System;
using System.Collections.Generic;
namespace SkiResort

{

    public class Shop
    {

        private List<SkiBase> Ski = new List<SkiBase>();
        

        // Constructor
        public Shop()
        {

        }



        public void AddSki(SkiBase skibase)
        {

            this.Ski.Add(skibase);

        }

        public void AddSKiShoes(string Brand, double RentPrice, string SkiShoeSize, int Type)
        {

        }

        public void Rent(string Brand, string Size)
        {
            foreach (SkiBase ski in Ski)
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

        public void Return(string Brand, string Size)
        {
            foreach (SkiBase ski in Ski)
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
            foreach (SkiBase ski in Ski)

            {
                if (ski.isAvailable)
                {

                    if (ski.Type == 1)
                    {

                        Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                            " Ski Rent Price: " + ski.RentPrice + "Availability: " + ski.isAvailable);
                    }

                    else if (ski.Type == 2)
                    {

                        Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                            " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                    }

                    else if (ski.Type == 3)
                    {

                        Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                            " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                    }
                    else if (ski.Type == 4)
                    {

                        Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                            " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                    }
                    else
                    {

                        Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                            " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                    }
                }
            }
        }

            public void listFullSkiList()
            {
            Console.WriteLine("-----------");
            Console.WriteLine("Ski List:");
            foreach (SkiBase ski in Ski)

            {
                if (ski.Type == 1) {
                   
                    Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                        " Ski Rent Price: " + ski.RentPrice + "Availability: " + ski.isAvailable);
                }

                else if(ski.Type == 2)
                {
                  
                    Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                        " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                }

                else if(ski.Type == 3)
                {
                   
                    Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                        " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                }
                else if(ski.Type == 4)
                {
                   
                    Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                        " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                }
                else
                {
                   
                    Console.WriteLine("Ski Brand: " + ski.Brand + " Ski Size: " + ski.SkiSize +
                        " Ski Rent Price: " + ski.RentPrice + " Availability: " + ski.isAvailable);
                }
            }

            
            } 
    }
}



    

