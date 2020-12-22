using System;
using System.Collections.Generic;


namespace SkiResort
{
    public class SkiVillage
    {

        private SkiShop skiShop;
        private Dictionary<slopeDifficulty, List<slopeBase>> SlopesCollection =
            new Dictionary<slopeDifficulty, List<slopeBase>>();
        private List<visitorBase> VisitorsCollection = new List<visitorBase>();

        // I am not sure how to initialize the Visitors:
        // So I did it the static way so I can atleast make the code work.

        //private Dictionary<VisitorAgeGroup, List<visitorBase>> VisitorsCollection =
        //new Dictionary<VisitorAgeGroup, List<visitorBase>>();

        // I am not sure how to initialize the Visitors:
        // So I did it the static way so I can atleast make the code work.



        public SkiVillage()
        {
            initDictionary();
            PopulateSlopes();
            //addVisitors();
            this.skiShop = new SkiShop();

        }

        private void initDictionary()
        {
            foreach (slopeDifficulty slopeDifficulty in Enum.GetValues(typeof(slopeDifficulty)))
            {
                SlopesCollection[slopeDifficulty] = new List<slopeBase>();
            }          
        }
           

        //public void addVisitors()
        //{
        //    VisitorsCollection.Add();
        //    VisitorsCollection.Add(mary);
        //}

        public void PopulateSlopes()
        {
            AddSlope(new Balkaniada());
            AddSlope(new Todorka());
            AddSlope(new Tomba());
        }

     

        public void AddSlope(slopeBase inputSlope)
        {
            SlopesCollection[inputSlope.pistDifficulty].Add(inputSlope);

        }

        public void SlopesInfo()
        {
            Console.WriteLine("-----------");
            foreach (slopeDifficulty slopeLevel in SlopesCollection.Keys)
            {
                foreach (slopeBase slope in SlopesCollection[slopeLevel])
                {
                    slope.Description();
                    break;
                }
            }
        }

        //public void VisitorsInfo()
        //{
        //    Console.WriteLine("-----------");
        //    foreach (VisitorAgeGroup visitorGroup in VisitorsCollection.Keys)
        //    {
        //        foreach (visitorBase visitor in VisitorsCollection[visitorGroup])
        //        {
        //            visitor.Description();
        //            break;
        //        }
        //    }
        //}

      

        //public visitorBase getVisitor()
        //{

        //    return VisitorsCollection;


        //}

        public void UseAvailableSlides(visitorBase visitor, slopeBase slope, int totalSlides, SkiBase ski)
        {
            
            
                visitor.DeductSlides(slope, totalSlides);
                visitor.CauseDamageSki(slope, ski, totalSlides);

            
            
        }

        public void BuySlides(visitorBase visitor, slopeBase Slope, int TotalSlides)
        {
            if (Slope.Capacity > 0 && Slope.Capacity - TotalSlides >= 0)
            {
                visitor.addSlides(Slope, TotalSlides);
                visitor.recalcMoney(Slope.PricePerSlide, TotalSlides);
                Console.WriteLine(visitor.Name + " thank you for purchasing Slides: " + TotalSlides + " for Slope: "
                    + Slope.pistname + " Price per Slide is: " + Slope.PricePerSlide);
                return;
            }
            Console.WriteLine(Slope.pistname + " has no more Slides Capicity");
            return;
        }

        public void listFullSkiList()
        {
            skiShop.listFullSkiList();
        }

        public void RentSki(visitorBase visitor , SkiBrands brand, SkiSizes size)
        {
            skiShop.RentSki(visitor, brand,size);
            
        }

        public void RentSkiShoes(visitorBase visitor, SkiShoesBrands brand, int size)
        {
            skiShop.RentSkiShoes(visitor, brand, size);
        }

        public void UserRentedEquipment(visitorBase visitor)
        {
            visitor.Description();
        }

        public void ReturnSki(visitorBase visitor, SkiBrands brand, SkiSizes size)
        {
            skiShop.ReturnSki(visitor, brand, size);
        }

        public void ReturnSkiShoes(visitorBase visitor, SkiShoesBrands brand, int size)
        {
            skiShop.ReturnSkiShoes(visitor, brand, size);
        }

        public void PrinteAvailableSlides (visitorBase visitor)
        {
            visitor.PrintAvailableSlides();
        }

        public void PrintPistCapacity(slopeBase slope)
        {
            Console.WriteLine(slope.pistname + " has capacity " + slope.GetCapacity());
        }

        public void PrintRentedEquipmentDurability(visitorBase visitor, SkiBase ski)
        {
            visitor.GetEquipmentDurability(ski);
        }



    }
}
