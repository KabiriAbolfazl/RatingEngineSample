using RatingEngineSample.Entities;
using RatingEngineSample.Interfaces;

namespace RatingEngineSample.Implementations
{
    internal class VehicleRatingEngine : IRatingEngine
    {
        public decimal Rate { get; set; }

        public void CalcRate(Insurance insurance, ILogger logger)
        {
            logger.Log("Rating Vehicle policy...");
            logger.Log("Validating policy.");
            if (DateTime.Now.Year - insurance.Year < 5)
            {
                Rate = insurance.Price * (5m / 100);
            }
            else
            {
                Rate = insurance.Price * (9m / 100);
            }
        }
    }
}
