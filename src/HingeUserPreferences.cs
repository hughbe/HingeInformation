using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeUserPreferences
    {
        [JsonProperty("distance_miles_max")]
        public int DistanceMilesMax { get; }

        [JsonProperty("age_min")]
        public int AgeMin { get; }

        [JsonProperty("age_max")]
        public int AgeMax { get; }

        [JsonProperty("age_dealbreaker")]
        public bool AgeDealbreaker { get; }
        [JsonProperty("height_min")]
        public int HeightMin { get; }

        [JsonProperty("height_max")]
        public int HeightMax { get; }

        [JsonProperty("height_dealbreaker")]
        public bool HeightDealbreaker { get; }

        [JsonProperty("gender_preference")]
        public string GenderPreference { get; }

        [JsonProperty("ethnicity_preference")]
        public IReadOnlyList<string> EthnicityPreference { get; }

        [JsonProperty("ethnicity_dealbreaker")]
        public bool EthnicityDealbreaker { get; }

        [JsonProperty("religion_preference")]
        public IReadOnlyList<string> ReligionPreference { get; }

        [JsonProperty("religion_dealbreaker")]
        public bool ReligionDealbreaker { get; }

        [JsonProperty("smoking_preference")]
        public IReadOnlyList<string> SmokingPreference { get; }

        [JsonProperty("smoking_dealbreaker")]
        public bool SmokingDealbreaker { get; }

        [JsonProperty("drinking_preference")]
        public IReadOnlyList<string> DrinkingPreference { get; }

        [JsonProperty("drinking_dealbreaker")]
        public bool DrinkingDealbreaker { get; }

        [JsonProperty("marijuana_preference")]
        public IReadOnlyList<string> MarijuanaPreference { get; }

        [JsonProperty("marijuana_dealbreaker")]
        public bool MarijuanaDealbreaker { get; }

        [JsonProperty("drugs_preference")]
        public IReadOnlyList<string> DrugsPreference { get; }

        [JsonProperty("drugs_dealbreaker")]
        public bool DrugsDealbreaker { get; }

        [JsonProperty("children_preference")]
        public IReadOnlyList<string> ChildrenPreference { get; }

        [JsonProperty("children_dealbreaker")]
        public bool ChildrenDealbreaker { get; }

        [JsonProperty("family_plans_preference")]
        public IReadOnlyList<string> FamilyPlansPreference { get; }

        [JsonProperty("family_plans_dealbreaker")]
        public bool FamilyPlansDealbreaker { get; }

        [JsonProperty("education_attained_preference")]
        public IReadOnlyList<string> EducationAttainedPreference { get; }

        [JsonProperty("education_attained_dealbreaker")]
        public bool EducationAttainedDealbreaker { get; }

        [JsonProperty("politics_preference")]
        public IReadOnlyList<string> PoliticsPreference { get; }

        [JsonProperty("politics_dealbreaker")]
        public bool PoliticsDealbreaker { get; }
    }
}
