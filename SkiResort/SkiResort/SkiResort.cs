using System;
using System.Collections.Generic;


namespace SkiResort
{
    public class SkiVillage
    {

        private SkiShop skiShop;
        private Dictionary<SlopeDifficulty, List<SlopeBase>> DifficultySlopes =
            new Dictionary<SlopeDifficulty, List<SlopeBase>>();

        private Dictionary<SlopeName, SlopeBase> NamedSlopes = new Dictionary<SlopeName, SlopeBase>();

        public SkiVillage()
        {
            initDictionary();
            PopulateSlopes();
            //addVisitors();
            this.skiShop = new SkiShop();

        }

        private void initDictionary()
        {
            foreach (SlopeDifficulty slopeDifficulty in Enum.GetValues(typeof(SlopeDifficulty)))
            {
                DifficultySlopes[slopeDifficulty] = new List<SlopeBase>();
            }          
        }
           
        private void PopulateSlopes()
        {
            AddSlope(new Balkaniada());
            AddSlope(new Todorka());
            AddSlope(new Tomba());
        }

     

        private void AddSlope(SlopeBase inputSlope)
        {
            DifficultySlopes[inputSlope.pistDifficulty].Add(inputSlope);
            NamedSlopes[inputSlope.pistname] = inputSlope;
        }

        public void SlopesInfo()
        {
            Console.WriteLine("-----------");
            foreach (SlopeDifficulty slopeLevel in DifficultySlopes.Keys)
            {
                foreach (SlopeBase slope in DifficultySlopes[slopeLevel])
                {
                    slope.Description();
                    break;
                }
            }
        }

        public void UseAvailableSlides(VisitorBase visitor, SlopeName slopeName)
        {


            SlopeBase slope = NamedSlopes[slopeName];
            if ( visitor.getAvailableSlidesForSlope(slope.pistname) > 0 && visitor.visitorHasEquipment() )
            {
                slope.ReduceCapacity();
                visitor.deductSlideForSlope(slope.pistname);
                visitor.CauseDamageSki(slope.getDurabilityCost());
            }
        }

        public void BuySlides(VisitorBase visitor, SlopeName slopeName, int totalSlides)
        {
            SlopeBase slope = NamedSlopes[slopeName];
            if (slope.Capacity > 0 && slope.Capacity - totalSlides >= 0)
            {
                visitor.addSlides(slope.pistname, totalSlides);
                visitor.reduceUserBalance(slope.PricePerSlide * totalSlides);
                Console.WriteLine(visitor.Name + " thank you for purchasing Slides: " + totalSlides + " for Slope: "
                    + slope.pistname + " Price per Slide is: " + slope.PricePerSlide);
                return;
            }
            Console.WriteLine(slope.pistname + " has no more Slides Capicity");
            return;
        }

        public void listFullSkiList()
        {
            skiShop.listFullSkiList();
        }

        public void RentSki(VisitorBase visitor , SkiBrands brand, SkiSizes size)
        {
            skiShop.RentSki(visitor, brand,size);
            
        }

        public void RentSkiShoes(VisitorBase visitor, SkiShoesBrands brand, int size)
        {
            skiShop.RentSkiShoes(visitor, brand, size);
        }

        public void UserRentedEquipment(VisitorBase visitor)
        {
            visitor.Description();
        }

        public void ReturnSki(VisitorBase visitor)
        {
            skiShop.ReturnSki(visitor);
        }

        public void ReturnSkiShoes(VisitorBase visitor)
        {
            skiShop.ReturnSkiShoes(visitor);
        }

        public void PrintPistCapacity(SlopeName slopeName)
        {
            Console.WriteLine(slopeName + " has capacity " + NamedSlopes[slopeName].Capacity);
        }

        public void PrintRentedEquipmentDurability(VisitorBase visitor)
        {
            visitor.GetEquipmentDurability();
        }



    }
}
