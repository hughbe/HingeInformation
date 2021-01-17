using System.IO;
using Newtonsoft.Json;

namespace HingeInformation
{
    internal class Utilities
    {
        public static T Read<T>(string path, string name)
        {
            using StreamReader reader = File.OpenText(Path.Combine(path, name + ".json"));
            var serializer = new JsonSerializer();
            serializer.MissingMemberHandling = MissingMemberHandling.Error;
            return (T)serializer.Deserialize(reader, typeof(T));
        }
    }
}
