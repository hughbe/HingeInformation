using System.Collections.Generic;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeMatch
    {
        [JsonProperty("block")]
        public IReadOnlyList<HingeBlock> Block { get; set; }

        [JsonProperty("chats")]
        public IReadOnlyList<HingeChat> Chats { get; set; }

        [JsonProperty("match")]
        public IReadOnlyList<HingeMatchMatch> Match { get; set; }

        [JsonProperty("like")]
        public IReadOnlyList<HingeLike> Like { get; set; }

        [JsonProperty("we_met")]
        public IReadOnlyList<HingeWeMet> WeMet { get; set; }
    }
}
