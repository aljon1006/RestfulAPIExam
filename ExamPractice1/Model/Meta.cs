using Newtonsoft.Json;

namespace ExamPractice1.Model
{
    public class Meta
    {
        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("licence")]
        public string Licence { get; set; }

        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("hasFormat")]
        public List<string> HasFormat { get; set; }
    }
}
