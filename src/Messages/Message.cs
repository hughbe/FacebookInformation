using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class Message
    {
        public string Id => Timestamp.ToString();

        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        [JsonProperty("timestamp_ms")]
        public long Timestamp { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("reactions")]
        public IList<MessageReaction> Reactions { get; set; }

        [JsonProperty("photos")]
        public IList<MessagePhoto> Photos { get; set; }

        [JsonProperty("videos")]
        public IList<MessageVideo> Videos { get; set; }

        [JsonProperty("audio_files")]
        public IList<MessageAudioFile> AudioFiles { get; set; }

        [JsonProperty("gifs")]
        public IList<MessageGif> Gif { get; set; }

        [JsonProperty("files")]
        public IList<MessageFile> Files { get; set; }

        [JsonProperty("share")]
        public MessageShare Share { get; set; }

        [JsonProperty("sticker")]
        public MessageSticker Sticker { get; set; }

        [JsonProperty("call_duration")]
        public int? CallDuration { get; set; }

        [JsonProperty("missed")]
        public bool? Missed { get; set; }

        [JsonProperty("users")]
        public IList<MessageParticipant> Users { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("type")]
        public MessageType Type { get; set; }

        public DateTime Date => Utilities.DateFromTimestampMilliseconds(Timestamp);

        public override string ToString() => $"({Date}) {SenderName}: {Content}";
    }
}
