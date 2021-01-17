using System.Runtime.Serialization;

namespace HingeInformation
{
    public enum HingeDevicePlatform
    {
        [EnumMember(Value = "ios")]
        iOS,

        [EnumMember(Value = "android")]
        Android
    }
}
