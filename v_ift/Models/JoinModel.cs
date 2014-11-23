using Newtonsoft.Json;

namespace v_ift.Models
{
    public class JoinModel
    {
       [JsonProperty(PropertyName = "lobbyId")]
        public string LobbyId { get; set; }

        [JsonProperty(PropertyName = "playerName")]
       public string PlayerName { get; set; }
    }
}