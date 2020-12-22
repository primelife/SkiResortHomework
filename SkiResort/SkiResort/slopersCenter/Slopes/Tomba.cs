using System;

namespace SkiResort

{
    public class Tomba : slopeBase
    {
        public Tomba() : base(slopeName.Tomba, slopeDurabilityCost.high, slopeDifficulty.intermediate,
            slopeSize.medium, 10 , 15)
        {
        }
    }
}
