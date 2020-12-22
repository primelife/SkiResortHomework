using System;

namespace SkiResort

{
    public class Tomba : SlopeBase
    {
        public Tomba() : base(SlopeName.Tomba, SlopeDurabilityCost.High, SlopeDifficulty.Intermediate,
            SlopeSize.Medium, 10 , 15)
        {
        }
    }
}
