using System;
using System.Collections.Generic;

namespace SkiResort
{
    public class SlopeBase
    {
        public SlopeName pistname { get; }
        public SlopeDurabilityCost pistDurabilityCost { get; }
        public SlopeDifficulty pistDifficulty {get; }
        public SlopeSize pistSize { get;  }
        public int PricePerSlide { get;  }
        public int Capacity { get; private set; }
       
        


        protected SlopeBase(SlopeName pistname, SlopeDurabilityCost pistDurabilityCost, SlopeDifficulty pistDifficulty, SlopeSize pistSize,
            int PricePerSlide, int Capacity)           
        {
            this.pistname = pistname;
            this.pistDurabilityCost = pistDurabilityCost;
            this.pistDifficulty = pistDifficulty;
            this.pistSize = pistSize;
            this.PricePerSlide = PricePerSlide;
            this.Capacity = Capacity;

        }

        public virtual void Description()
        {

            Console.WriteLine("*Piste Name " + pistname + "* *is Difficulty: " + pistDifficulty +
                "* *Size is: " + pistSize + "* *price per Run is: " + PricePerSlide + "*");

        }

        public void ReduceCapacity()
        {
            this.Capacity -= 1;
        }

        public void IncreaseCapacity()
        {
            this.Capacity += 1;
        }

        public int getDurabilityCost()
        {
            switch (pistDurabilityCost)
            {
                case SlopeDurabilityCost.Low: return 10;
                case SlopeDurabilityCost.Mid: return 20;
                case SlopeDurabilityCost.High: return 30;
                default: return 0;
            }
        }


        //3. We should have 3 different types of Slopes.Ski Slopes (types of difficulty)
        //     * 4. This Human(visitor) cannot exceed the limit of humans per Slope.
        //     * 5. Each Slope costs money. Takes money per Slide. User needs to pay for 
        //     * every trip up the slope.

        //    * 6. We have multiple Humans
        //     * 7. Every Slope costs durability for the equipment. Equipment can go faulty.

    }
}
