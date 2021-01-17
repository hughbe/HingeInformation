using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeUserIdentity
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("instagram_authorized")]
        public bool InstagramAuthorized { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phone_country_code")]
        public string PhoneCountryCode { get; set; }

        [JsonProperty("phone_country_calling_code")]
        public int PhoneCountryCallingCode { get; set; }

        [JsonProperty("phone_carrier")]
        public string PhoneCarrier { get; set; }

        [JsonProperty("phone_line_type")]
        public HingePhoneLineType PhoneLineType { get; set; }
    }
}
