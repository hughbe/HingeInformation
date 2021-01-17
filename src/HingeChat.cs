using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeChat
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("type")]
        public HingeMatchType Type { get; set; }
    }
}
