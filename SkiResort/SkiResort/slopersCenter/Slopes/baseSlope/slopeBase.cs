using System;
using System.Collections.Generic;

namespace SkiResort
{
    public class slopeBase
    {
        public slopeName pistname { get; }
        public slopeDurabilityCost pistDurabilityCost { get; }
        public slopeDifficulty pistDifficulty {get; }
        public slopeSize pistSize { get;  }
        public int PricePerSlide { get;  }
        public int Capacity { get; set; }
       
        


        protected slopeBase(slopeName pistname, slopeDurabilityCost pistDurabilityCost, slopeDifficulty pistDifficulty, slopeSize pistSize,
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

        public void ReduceCapacity(int NumSlides)
        {
            this.Capacity = Capacity - NumSlides;
        }

        public void IncreaseCapacity(int NumSlides)
        {
            this.Capacity = Capacity + NumSlides;
        }

        public int GetCapacity()
        {
            return Capacity;
        }


        //3. We should have 3 different types of Slopes.Ski Slopes (types of difficulty)
        //     * 4. This Human(visitor) cannot exceed the limit of humans per Slope.
        //     * 5. Each Slope costs money. Takes money per Slide. User needs to pay for 
        //     * every trip up the slope.

        //    * 6. We have multiple Humans
        //     * 7. Every Slope costs durability for the equipment. Equipment can go faulty.

    }
}
