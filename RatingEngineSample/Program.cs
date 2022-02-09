// See https://aka.ms/new-console-template for more information
using RatingEngineSample.Implementations;

RatingEngine ratingEngine = new RatingEngine(new ConsoleLogger(),new JsonReader());
Console.WriteLine(ratingEngine.Rate());
