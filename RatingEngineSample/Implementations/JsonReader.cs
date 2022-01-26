using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RatingEngineSample.Entities;
using RatingEngineSample.Interfaces;

namespace RatingEngineSample.Implementations
{
    internal class JsonReader : IReader
    {
        public Insurance Read(string url)
        {
            var jsonInfo = File.ReadAllText(url);
            return JsonConvert.DeserializeObject<Insurance>(jsonInfo, new StringEnumConverter());
        }
    }
}
