using ExamPractice1.Controllers;
using Newtonsoft.Json;

namespace ExamPractice1.Model
{
    public class RainFallMeasurement
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }
}
