using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeLike
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("type")]
        public HingeMatchType Type { get; set; }
    }
}
