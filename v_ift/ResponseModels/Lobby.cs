using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using v_ift.Models;

namespace v_ift.ResponseModels
{
    public class Lobby
    {
        public Lobby(LobbyDataBaseModel lobbyDataBaseModel, string id)
        {
            this.Status = lobbyDataBaseModel.Status;
            this.Players = lobbyDataBaseModel.Players.Select(arg => new Player(arg)).ToList();
            this.LobbyGuid = lobbyDataBaseModel.LobbyName;
            this.Count = lobbyDataBaseModel.Count;
            this.PlayerToken = id;
            this.Distance = lobbyDataBaseModel.Distance;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.Status Status { get; set; }

        [JsonProperty(PropertyName = "players")]
        public List<Player> Players { get; set; }

        [JsonProperty(PropertyName = "lobbyguid")]
        public string LobbyGuid { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "playerToken")]
        public string PlayerToken { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public double Distance { get; set; }
    }
}