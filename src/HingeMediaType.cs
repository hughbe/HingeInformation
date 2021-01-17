using System.Runtime.Serialization;

namespace HingeInformation
{
    public enum HingeMediaType
    {
        [EnumMember(Value = "photo")]
        Photo,

        [EnumMember(Value = "video")]
        Video
    }
}
