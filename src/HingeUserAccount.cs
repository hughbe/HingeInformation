using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeUserAccount
    {
        [JsonProperty("authentication_source")]
        public string AuthenticationSource { get; set; }

        [JsonProperty("signup_time")]
        public DateTime SignupTime { get; set; }

        [JsonProperty("last_seen")]
        public DateTime LastSeen { get; set; }

        [JsonProperty("device_platform")]
        public HingeDevicePlatform DevicePlatform { get; set; }

        [JsonProperty("device_os")]
        public Version DeviceOS { get; set; }

        [JsonProperty("device_model")]
        public string DeviceModel { get; set; }

        [JsonProperty("app_version")]
        public Version AppVersion { get; set; }

        [JsonProperty("push_notifications_enabled")]
        public bool PushNotificationsEnabled { get; set; }
    }
}
