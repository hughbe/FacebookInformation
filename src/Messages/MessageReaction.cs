using System;
using System.Linq;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessageReaction
    {
        [JsonProperty("reaction")]
        public string Reaction { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        public const string HeartReaction = "\u00E2\u009D\u00A4";

        public const string HahaReaction = "\u00f0\u009f\u0098\u008d";

        public const string HeartEyeReaction = "\u00f0\u009f\u0098\u0086";

        public const string ThumbsUpReaction = "\u00F0\u009F\u0091\u008D";

        public const string ThumbsDownReaction = "\u00F0\u009F\u0091\u008E";

        public const string AngeryReaction = "\u00F0\u009F\u0098\u00A0";

        public const string WowReaction = "\u00F0\u009F\u0098\u00AE";

        public const string CryReaction = "\u00F0\u009F\u0098\u00A2";

        public string ReactionName
        {
            get
            {
                if (Reaction == HeartReaction)
                {
                    return "Cri";
                }
                else if (Reaction == HahaReaction)
                {
                    return "Haha";
                }
                else if (Reaction == HeartEyeReaction)
                {
                    return "Heart Eyes";
                }
                else if (Reaction == ThumbsUpReaction)
                {
                    return "Thumbs Up";
                }
                else if (Reaction == ThumbsDownReaction)
                {
                    return "Thumbs Down";
                }
                else if (Reaction == AngeryReaction)
                {
                    return "Angerey";
                }
                else if (Reaction == WowReaction)
                {
                    return "Wow";
                }
                else if (Reaction == CryReaction)
                {
                    return "Cri";
                }

                string unicode = string.Join("", Reaction.Select(c => $"\\u{(short)c:X4}"));
                throw new NotImplementedException($"Unhandled reaction: \"{unicode}\"");
            }
        }
    }
}
