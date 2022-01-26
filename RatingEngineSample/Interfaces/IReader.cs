using RatingEngineSample.Entities;

namespace RatingEngineSample.Interfaces
{
    internal interface IReader 
    { 
        Insurance Read(string url);
    }
}
