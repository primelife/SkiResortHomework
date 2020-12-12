using System;
using System.Collections.Generic;

namespace SkiResort

{

    public class Shop
    {

        private Dictionary<SkiBrands, List<SkiBase>> Ski = new Dictionary<SkiBrands, List<SkiBase>>();
        private Dictionary<SkiShoesBrands, List<SkiShoesBase>> SkiShoes
            = new Dictionary<SkiShoesBrands, List<SkiShoesBase>>();

        public Shop()
        {
            initDictionary();
            populateSki();
            populateSkiShoes();
        }
       
        private void initDictionary()
        {
            foreach (SkiBrands skiBrand in Enum.GetValues(typeof(SkiBrands)))
            {
                Ski[skiBrand] = new List<SkiBase>();
            }

            foreach (SkiShoesBrands skiShoesBrand in Enum.GetValues(typeof(SkiShoesBrands)))
            {
                SkiShoes[skiShoesBrand] = new List<SkiShoesBase>();
            }
        }


        private void populateSki()
        {          
            AddSki(new HondaSkiModelX());
            AddSki(new SkodaSkiModelY());
            AddSki(new SuzukiSkiModelSpeed());
            AddSki(new ToyotaSkiModelW());
            AddSki(new YamahaSkiModelZ());
        }


        private void populateSkiShoes()
        {
            for(int i = 35; i < 46; i++)
            {
                AddSkiShoes(new FischerShoesModelS(i));
                AddSkiShoes(new NordicaShoesModelE(i));
                AddSkiShoes(new NorthSkiShoesType4X(i));
                AddSkiShoes(new SalomonShoesModelY(i));
            }
        }

        private void AddSki(SkiBase inputSki)
        {
            Ski[inputSki.Brand].Add(inputSki);
        }

        private void AddSkiShoes(SkiShoesBase inputSkiShoes)
        {
            SkiShoes[inputSkiShoes.Brand].Add(inputSkiShoes);
        }

        public void RentSki(SkiBrands Brand, SkiSizes Size)
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


        public void ReturnSki(SkiBrands Brand, SkiSizes Size)
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

        public void RentSkiShoes(SkiShoesBrands Brand, int Size)
        {


            foreach (SkiShoesBase shoe in SkiShoes[Brand])
            {
                if (shoe.Brand == Brand && shoe.ShoeSize == Size)
                {
                Console.WriteLine("--------");

                    shoe.SizeAvailable = false;
                Console.WriteLine("Succesfully rented SkiShoes " + Brand + " Size: " + Size);
                return;
                }               
            }
            Console.WriteLine("There is no item with Brand: " + Brand + " and Size: " + Size);
        }

        public void ReturnSkiShoes(SkiShoesBrands Brand, int Size)
        {
            foreach (SkiShoesBase shoe in SkiShoes[Brand])
            {
                if (shoe.Brand == Brand & !shoe.SizeAvailable)
                {
                    shoe.SizeAvailable = true;
                    Console.WriteLine("You've returned SkiShoe " + Brand + " Size: " + Size);
                        return;
                    }

                Console.WriteLine("Not sure what this item is.");
                    return;
                


            }
            Console.WriteLine("There is no item with Brand: " + Brand + " and Size: " + Size);
        }

        public void SkiDescription(SkiBrands brand)

        {
            List<SkiBase> skiBaseList = Ski[brand];
            foreach (SkiBase skiObject in skiBaseList)
            {
                skiObject.Description();
                break;
            }
        }

        public void SkiShoesDescription(SkiShoesBrands shoebrand)
        {
            foreach (SkiShoesBase shoe in SkiShoes[shoebrand])
            {
                shoe.Description();
            }
        }

        public void listAvailableSki(SkiBrands Brand)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Avaible Ski List:");
            foreach (SkiBase ski in Ski[Brand])
            {
                if (ski.isAvailable) ski.Description();
               
            }

        }

        public void listAvailableShoeSizes(SkiShoesBrands brand)
        {
            foreach (SkiShoesBase shoe in SkiShoes[brand])
            {
                if (shoe.SizeAvailable) shoe.Description();
            }
        }

        public void listFullSkiList()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Ski List:");
            foreach (SkiBrands skiBrand in Ski.Keys)
            {
                foreach (SkiBase ski in Ski[skiBrand])
                {
                    ski.PrintAvailability();
                    break;
                }
            }

        }

        public void  listFullSkiShoesList()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("SkiShoes Brands:");
            foreach (SkiShoesBrands skiShoesBrand in SkiShoes.Keys)
            {
               foreach (SkiShoesBase ski in SkiShoes[skiShoesBrand])
                {
                    ski.Description();
                }
              
            }

        }


    }
}





    

