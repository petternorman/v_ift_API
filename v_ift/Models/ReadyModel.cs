﻿using Newtonsoft.Json;

namespace v_ift.Models
{
    public class ReadyModel
    {
        [JsonProperty(PropertyName = "lobbyId")]
        public string LobbyId { get; set; }

        [JsonProperty(PropertyName = "playerId")]
        public string PlayerId { get; set; }
    }
}