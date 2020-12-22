using System;
using System.Collections.Generic;

namespace SkiResort

{
    public class SkiShop
    {


        private visitorBase ShopVisitor { get;  }
        private Dictionary<SkiBrands, List<SkiBase>> Ski = new Dictionary<SkiBrands, List<SkiBase>>();
        private Dictionary<SkiShoesBrands, List<SkiShoesBase>> SkiShoes
            = new Dictionary<SkiShoesBrands, List<SkiShoesBase>>();

        public SkiShop()
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
            for (int i = 35; i < 37; i++)
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

        public SkiBase RentSki(visitorBase visitor,SkiBrands Brand, SkiSizes Size)
        {


            foreach (SkiBase ski in Ski[Brand])
            {
                if (ski.Brand == Brand & ski.SkiSize == Size)
                {
                    ski.isAvailable = false;
                    visitor.AddToRentedSKiList(ski);
                    
                    Console.WriteLine("You've rented Ski " + Brand + " Size: " + Size);
                    return ski;
                }


            }
            Console.WriteLine("There is no item with Brand: " + Brand + " and Size: " + Size);
            return null;
        }


        public SkiBase ReturnSki(visitorBase visitor, SkiBrands Brand, SkiSizes Size)
        {
            foreach (SkiBase ski in Ski[Brand])
            {
                if (ski.Brand == Brand & ski.SkiSize == Size)
                {
                    ski.isAvailable = true;
                    visitor.RemoveFromRentedSKiList(ski);

                    Console.WriteLine("You've return Ski " + Brand + " Size: " + Size);
                    return ski;
                }


            }
            Console.WriteLine("There is no item with Brand: " + Brand + " and Size: " + Size);
            return null;

        }

        public SkiShoesBase RentSkiShoes(visitorBase visitor, SkiShoesBrands Brand, int Size)
        {


            foreach (SkiShoesBase shoe in SkiShoes[Brand])
            {
                if (shoe.Brand == Brand && shoe.ShoeSize == Size)
                {
                    Console.WriteLine("--------");

                    shoe.SizeAvailable = false;
                    visitor.AddToRentedSKiShoesList(shoe);

                    Console.WriteLine("Succesfully rented SkiShoes " + Brand + " Size: " + Size);
                    return shoe;
                }
            }
            Console.WriteLine("There is no item with Brand: " + Brand + " and Size: " + Size);
            return null;

        }


        public void ReturnSkiShoes(visitorBase visitor, SkiShoesBrands Brand, int Size)
        {
            foreach (SkiShoesBase shoe in SkiShoes[Brand])
            {

                if (shoe.Brand == Brand && shoe.ShoeSize == Size)
                {
                    shoe.SizeAvailable = true;
                    visitor.RemoveFromRentedSKiShoesList(shoe);
                    Console.WriteLine("You've returned SkiShoe " + Brand + " Size: " + Size);
                    return;
                }

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

        public void listFullSkiShoesList()
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






    

