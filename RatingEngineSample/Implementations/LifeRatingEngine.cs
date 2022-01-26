using RatingEngineSample.Entities;
using RatingEngineSample.Interfaces;

namespace RatingEngineSample.Implementations
{
    internal class LifeRatingEngine : IRatingEngine
    {
        public decimal Rate { get; set; }

        public void CalcRate(Insurance insurance, ILogger logger)
        {
            if (insurance.DateOfBirth == DateTime.MinValue)
            {
                logger.Log("Life policy must include Date of Birth.");

            }
            if (insurance.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                logger.Log("Centenarians are not eligible for coverage.");

            }
            if (insurance.Amount == 0)
            {
                logger.Log("Life policy must include an Amount.");
            }
            int age = DateTime.Today.Year - insurance.DateOfBirth.Year;
            if (insurance.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < insurance.DateOfBirth.Day ||
                DateTime.Today.Month < insurance.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = insurance.Amount * age / 200;
            if (insurance.IsSmoker)
            {
                Rate = baseRate * 2;

            }
            Rate = baseRate;
        }
    }
}
