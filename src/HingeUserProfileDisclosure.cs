using System.Runtime.Serialization;

namespace HingeInformation
{
    public enum HingeUserProfileDisclosure
    {
        [EnumMember(Value = "No")]
        No,

        [EnumMember(Value = "Yes")]
        Yes,

        [EnumMember(Value = "Prefer not to say")]
        PreferNotToSay
    }
}
