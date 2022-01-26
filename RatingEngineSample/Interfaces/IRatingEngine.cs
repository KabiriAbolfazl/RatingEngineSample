using RatingEngineSample.Entities;

namespace RatingEngineSample.Interfaces
{
    internal interface IRatingEngine
    {
        public decimal Rate { get; set; }
        void CalcRate(Insurance insurance, ILogger logger);
    }
}
