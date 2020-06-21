using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MessageThread
    {
        [JsonProperty("participants")]
        public IList<MessageParticipant> Participants { get; set; }

        [JsonProperty("messages")]
        public IList<Message> Messages { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("is_still_participant")]
        public bool IsStillParticipant { get; set; }

        [JsonProperty("thread_path")]
        public string ThreadPath { get; set; }

        [JsonProperty("thread_type")]
        public MessageThreadType ThreadType { get; set; }

        public override string ToString()
            => $"Conversation: {string.Join(", ", Participants)} with {Messages.Count} messages";
    }
}
