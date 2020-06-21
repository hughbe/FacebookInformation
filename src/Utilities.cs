using System;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    internal static class Utilities
    {
        public static DateTime DateFromTimestampMilliseconds(long timestamp)
        {
            long timestampSeconds = timestamp / 1000;
            long timestampRemainerMilliseconds = timestamp % 1000;
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);
            return unixEpoch
                .AddSeconds(timestampSeconds)
                .AddMilliseconds(timestampRemainerMilliseconds);
        }

        public static DateTime DateFromTimestampSeconds(long timestamp)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);
            return unixEpoch
                .AddSeconds(timestamp);
        }

        public static T Read<T>(string path, string name)
        {
            using StreamReader reader = File.OpenText(Path.Combine(path, name + ".json"));
            var serializer = new JsonSerializer();
            serializer.MissingMemberHandling = MissingMemberHandling.Error;
            return (T)serializer.Deserialize(reader, typeof(T));
        }
    }
}
