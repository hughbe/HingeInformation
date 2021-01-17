using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingePrompt
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }
    }
}
