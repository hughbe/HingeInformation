using System.Runtime.Serialization;

namespace HingeInformation
{
    public enum HingeMatchType
    {
        [EnumMember(Value = "block")]
        Block,

        [EnumMember(Value = "chats")]
        Chats,

        [EnumMember(Value = "match")]
        Match,

        [EnumMember(Value = "like")]
        Like,

        [EnumMember(Value = "we_met")]
        WeMet
    }
}
