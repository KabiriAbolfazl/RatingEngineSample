using RatingEngineSample.Interfaces;

namespace RatingEngineSample.Implementations
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
