using System;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeUserLocation
    {
        [JsonProperty("latitude")]
        public double Latitude { get; }

        [JsonProperty("longitude")]
        public double Longitude { get; }

        [JsonProperty("country")]
        public string Country { get; }

        [JsonProperty("country_short")]
        public string CountryShort { get; }

        [JsonProperty("admin_area_1")]
        public string AdminArea1 { get; }

        [JsonProperty("admin_area_1_short")]
        public string AdminArea1Short { get; }

        [JsonProperty("admin_area_2")]
        public string AdminArea2 { get; }

        [JsonProperty("admin_area_2_short")]
        public string AdminArea2Short { get; }

        [JsonProperty("cbsa")]
        public string Cbsa { get; }

        [JsonProperty("locality")]
        public string Locality { get; }

        [JsonProperty("sublocality")]
        public string Sublocality { get; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; }

        [JsonProperty("location_source")]
        public string LocationSource { get; }
    }
}
