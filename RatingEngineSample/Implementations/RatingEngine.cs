using RatingEngineSample.Entities;
using RatingEngineSample.Interfaces;

namespace RatingEngineSample.Implementations
{
    internal class RatingEngine
    {
        internal IRatingEngine _ratingEngine;
        private readonly ILogger _logger;
        private readonly IReader _reader;
        public RatingEngine()
        {
            _logger = new ConsoleLogger();
            _reader = new JsonReader();
        }
        public decimal Rate()
        {
            _logger.Log("Starting rate.");
            _logger.Log("Loading policy.");
            var policy = _reader.Read("../policy.json");
            switch (policy.Type)
            {
                case InsuranceType.Vehicle:
                    _logger.Log("Rating Vehicle policy...");
                    _logger.Log("Validating policy.");
                    _ratingEngine = new VehicleRatingEngine();
                    _ratingEngine.CalcRate(policy, _logger);
                    break;

                case InsuranceType.Life:
                    _logger.Log("Rating LIFE policy...");
                    _logger.Log("Validating policy.");
                    _ratingEngine = new LifeRatingEngine();
                    _ratingEngine.CalcRate(policy, _logger);
                    break;

                default:
                    _logger.Log("Unknown policy type");
                    break;
            }

            _logger.Log("Rating completed.");
            return _ratingEngine.Rate;
        }
    }
}
