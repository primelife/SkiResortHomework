using System;
using System.Collections.Generic;

namespace SkiResort
{
    public class VisitorBase
    {
        
        public int Age { get; }
        public string Name { get; }
        public SkiBase RentedSki { get; private set; }
        public SkiShoesBase RentedSkiShoe { get; private set; }
        private int Money = 1000;
        private Dictionary<SlopeName, int> numberOfSlidesBought = new Dictionary<SlopeName, int>();
        

        public VisitorBase(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public virtual void Description()
        {
            Console.WriteLine("*" + Name + " Age: " + Age);

            if (RentedSki == null & RentedSkiShoe == null)
            {
                Console.WriteLine(Name + " has nothing rented. ");
                return;
            }

            Console.WriteLine(Name + " rented SKI: " + RentedSki.Brand + " with size: " + RentedSki.SkiSize);
            Console.WriteLine(Name + " rented SkiShoes: " + RentedSkiShoe.Brand + " with size: " + RentedSkiShoe.ShoeSize);
        }

        public void addSlides(SlopeName slopeName, int numOfSlides)
        {
            int availableSlopes = numberOfSlidesBought.ContainsKey(slopeName) ? numberOfSlidesBought[slopeName] : 0;
            numberOfSlidesBought.Add(slopeName, availableSlopes + numOfSlides);
        }

        public void CauseDamageSki(int damageAmount)
        {
            RentedSki.reduceDurability(damageAmount);
        }
            

        public void GetEquipmentDurability()
        {
            if (RentedSki == null & RentedSkiShoe == null)
            {
                Console.WriteLine(Name + " has nothing rented. ");
                return;
            }

            Console.WriteLine("Durabity is: " + RentedSki.getDurability() + " and availability is: " + RentedSki.isAvailable);
        }

        public void reduceUserBalance(int creditAmount)
        {
            Money -= creditAmount;
        }

        public int getAvailableFunds()
        {
            return Money;
        }

        public int getAvailableSlidesForSlope(SlopeName slopeName)
        {
            return numberOfSlidesBought[slopeName];
        }

        public void deductSlideForSlope(SlopeName slopeName)
        {
            numberOfSlidesBought[slopeName] -= 1;
        }

        public void setRentedSki(SkiBase ski)
        {
            RentedSki = ski;
        }

        public void setRentedSkiShoes(SkiShoesBase shoe)
        {
            RentedSkiShoe = shoe;
        }

        public bool visitorHasEquipment()
        {
            return RentedSki != null && RentedSkiShoe != null;
        }

    }
}
