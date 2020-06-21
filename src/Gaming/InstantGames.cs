using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class InstantGames
    {
        [JsonProperty("instant_games_played")]
        public IReadOnlyList<InstantGame> Played { get; set; }
    }
}
