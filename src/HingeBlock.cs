using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeBlock
    {
        [JsonProperty("block_type")]
        public HingeBlockType BlockType { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("type")]
        public HingeMatchType Type { get; set; }
    }
}
