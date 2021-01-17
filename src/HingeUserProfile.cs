using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HingeInformation
{
    public class HingeUserProfile
    {
        [JsonProperty("first_name")]
        public string FirstName { get; }

        [JsonProperty("last_name")]
        public string LastName { get; }

        [JsonProperty("age")]
        public int Age { get; }

        [JsonProperty("height_centimeters")]
        public int HeightCentimeters { get; }

        [JsonProperty("gender")]
        public string Gender { get; }

        [JsonProperty("gender_identity")]
        public string GenderIdentity { get; }

        [JsonProperty("gender_identity_displayed")]
        public bool GenderIdentityDisplayed { get; }

        [JsonProperty("ethnicities")]
        public IReadOnlyList<string> Ethnicities { get; }

        [JsonProperty("ethnicities_displayed")]
        public bool EthnicitiesDisplayed { get; }

        [JsonProperty("religions")]
        public IReadOnlyList<string> Religions { get; }

        [JsonProperty("religions_displayed")]
        public bool ReligionsDisplayed { get; }

        [JsonProperty("workplaces")]
        public IReadOnlyList<string> Workplaces { get; }

        [JsonProperty("workplaces_displayed")]
        public bool WorkplacesDisplayed { get; }

        [JsonProperty("job_title")]
        public string JobTitle { get; }

        [JsonProperty("job_title_displayed")]
        public bool JobTitleDisplayed { get; }

        [JsonProperty("schools")]
        public IReadOnlyList<string> Schools { get; }

        [JsonProperty("schools_displayed")]
        public bool SchoolsDisplayed { get; }

        [JsonProperty("hometowns")]
        public IReadOnlyList<string> Hometowns { get; }

        [JsonProperty("hometowns_displayed")]
        public bool HometownsDisplayed { get; }

        [JsonProperty("smoking")]
        public HingeUserProfileDisclosure Smoking { get; }

        [JsonProperty("smoking_displayed")]
        public bool SmokingDisplayed { get; }

        [JsonProperty("drinking")]
        public HingeUserProfileDisclosure Drinking { get; }

        [JsonProperty("drinking_displayed")]
        public bool DrinkingDisplayed { get; }

        [JsonProperty("marijuana")]
        public HingeUserProfileDisclosure Marijuana { get; }

        [JsonProperty("marijuana_displayed")]
        public bool MarijuanaDisplayed { get; }

        [JsonProperty("drugs")]
        public HingeUserProfileDisclosure Drugs { get; }

        [JsonProperty("drugs_displayed")]
        public bool DrugsDisplayed { get; }

        [JsonProperty("children")]
        public HingeUserProfileChildrenDisclosure Children { get; }

        [JsonProperty("children_displayed")]
        public bool ChildrenDisplayed { get; }

        [JsonProperty("family_plans")]
        public HingeUserProfileFamilyPlansDisclosure FamilyPlans { get; }

        [JsonProperty("family_plans_displayed")]
        public bool FamilyPlansDisplayed { get; }

        [JsonProperty("education_attained")]
        public HingeUserProfileEducationAttained EducationAttained { get; }

        [JsonProperty("politics")]
        public string Politics { get; }

        [JsonProperty("politics_displayed")]
        public bool PoliticsDisplayed { get; }

        [JsonProperty("instagram_displayed")]
        public bool InstagramDisplayed { get; }
    }
}
