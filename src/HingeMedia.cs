using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeMedia
    {
        [JsonProperty("type")]
        public HingeMediaType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("location")]
        public HingeMediaLocation Location { get; set; }

        [JsonProperty("from_social_media")]
        public bool FromSocialMedia { get; set; }
    }
}
