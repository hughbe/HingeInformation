using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeUserInstall
    {
        [JsonProperty("ip_address")]
        public string IPAddress { get; set; }

        [JsonProperty("idfv")]
        public string IDFV { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("install_time")]
        public DateTime InstallTime { get; set; }
    }
}
