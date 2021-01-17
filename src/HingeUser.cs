using System.Collections.Generic;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeUser
    {
        [JsonProperty("identity")]
        public HingeUserIdentity Identity { get; set; }

        [JsonProperty("account")]
        public HingeUserAccount Account { get; set; }

        [JsonProperty("location")]
        public HingeUserLocation Location { get; set; }

        [JsonProperty("installs")]
        public IReadOnlyList<HingeUserInstall> Installs { get; set; }

        [JsonProperty("profile")]
        public HingeUserProfile Profile { get; set; }

        [JsonProperty("preferences")]
        public HingeUserPreferences Preferences { get; set; }
    }
}
