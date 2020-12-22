using System;
using System.Collections.Generic;

namespace SkiResort
{
    public class visitorBase
    {
        
        public int Age { get; }
        public string Name { get; }
        public int Slides = 0;
        public List<SkiBase> RentedSki = new List<SkiBase>();
        public List<SkiShoesBase> RentedSkiShoes = new List<SkiShoesBase>();
        public SkiBase ski { get; }
        public SkiShoesBase skiShoes { get; }
        public int Money = 1000;




        public visitorBase(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public virtual void Description()
        {
            Console.WriteLine("*" + Name + " Age: " + Age);

            if (RentedSki == null & RentedSkiShoes == null)
            {
                Console.WriteLine(Name + " has nothing rented. ");

            }

            foreach (SkiBase ski in RentedSki)
            {
                Console.WriteLine(Name + " rented SKI: " + ski.Brand + " with size: " + ski.SkiSize);
            }

            foreach (SkiShoesBase skiShoes in RentedSkiShoes)
            {
                Console.WriteLine(Name + " rented SkiShoes: " + skiShoes.Brand + " with size: " + skiShoes.ShoeSize);
            }
        }

        public void AddToRentedSKiList(SkiBase ski)
        {
            RentedSki.Add(ski);
        }
        public void AddToRentedSKiShoesList(SkiShoesBase skiShoes)
        {
            RentedSkiShoes.Add(skiShoes);
        }

        public void RemoveFromRentedSKiList(SkiBase ski)
        {
            RentedSki.Remove(ski);
        }

        public void RemoveFromRentedSKiShoesList(SkiShoesBase skiShoes)
        {
            RentedSkiShoes.Remove(skiShoes);

        }

        public void addSlides(slopeBase Slope, int TotalSlides)
        {
           
            
                Slope.ReduceCapacity(TotalSlides);
                this.Slides = Slides + TotalSlides;
            
            

        }

        public void DeductSlides(slopeBase Slope, int TotalSlides)
        {
          
            Slope.IncreaseCapacity(TotalSlides);
            this.Slides = Slides - TotalSlides;
            Console.WriteLine("You Used " + TotalSlides + " slides.");
        }

        public void PrintAvailableSlides()
        {
            Console.WriteLine("You have " + Slides + " available slides.");
        }

        public void CauseDamageSki(slopeBase slope, SkiBase ski, int totalSlides)
        {

            ski.reCalcDurability(slope, totalSlides);
            
        }

        public void GetEquipmentDurability(SkiBase ski)
        {
            Console.WriteLine("Durabity is: " + ski.Durability + " and availability is: " + ski.isAvailable);
        }

        public void recalcMoney(int priceSlide, int TotalSlides)
        {
            Money = Money - priceSlide*TotalSlides;
        }



    }
}
