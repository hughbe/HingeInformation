using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeMatchMatch
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("type")]
        public HingeMatchType Type { get; set; }
    }
}
