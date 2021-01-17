using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeWeMet
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("did_meet_subject")]
        public bool DidMeetSubject { get; set; }

        [JsonProperty("was_my_type")]
        public bool? WasMyType { get; set; }

        [JsonProperty("type")]
        public HingeMatchType Type { get; set; }
    }
}
