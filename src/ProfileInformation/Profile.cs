using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Profile
    {
        [JsonProperty("name")]
        public ProfileName Name { get; set; }

        [JsonProperty("emails")]
        public ProfileEmails Emails { get; set; }

        [JsonProperty("birthday")]
        public ProfileDate Birthday { get; set; }

        [JsonProperty("gender")]
        public ProfileGender Gender { get; set; }

        [JsonProperty("previous_names")]
        public IReadOnlyList<ProfilePreviousName> PreviousNames { get; set; }

        [JsonProperty("other_names")]
        public IReadOnlyList<string> OtherNames { get; set; }

        [JsonProperty("current_city")]
        public ProfileCity CurrentCity { get; set; }

        [JsonProperty("hometown")]
        public ProfileCity Hometown { get; set; }

        [JsonProperty("relationship")]
        public ProfileRelationship Relationship { get; set; }

        [JsonProperty("previous_relationships")]
        public IReadOnlyList<ProfilePreviousRelationship> PreviousRelationships { get; set; }

        [JsonProperty("family_members")]
        public IReadOnlyList<ProfileFamilyMember> FamilyMembers { get; set; }

        [JsonProperty("education_experiences")]
        public IReadOnlyList<ProfileEducationExperiences> EducationExperiences { get; set; }

        [JsonProperty("work_experiences")]
        public IReadOnlyList<ProfileWorkExperience> WorkExperiences { get; set; }

        [JsonProperty("political_view")]
        public ProfilePoliticalView PoliticalView { get; set; }

        [JsonProperty("blood_info")]
        public ProfileBloodInformation BloodInformation { get; set; }

        [JsonProperty("phone_numbers")]
        public IReadOnlyList<ProfilePhoneNumber> PhoneNumbers { get; set; }

        [JsonProperty("pages")]
        public IReadOnlyList<ProfilePage> Pages { get; set; }

        [JsonProperty("groups")]
        public IReadOnlyList<ProfileGroup> Groups { get; set; }

        [JsonProperty("registration_timestamp")]
        public long RegistrationTimestamp { get; set; }

        [JsonProperty("profile_uri")]
        public string Uri { get; set; }

        public DateTime RegistrationDate => Utilities.DateFromTimestampSeconds(RegistrationTimestamp);

        public override string ToString() => Name.ToString();
    }
}
