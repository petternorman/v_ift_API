using Newtonsoft.Json;

namespace v_ift.Models
{
    public class PositionModel
    {
        [JsonProperty(PropertyName = "lobbyId")]
        public string LobbyId { get; set; }

        [JsonProperty(PropertyName = "playerId")]
        public string PlayerId { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public double Lng { get; set; }

        [JsonProperty(PropertyName = "lat")]
        public double Lat { get; set; }
    }
}