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
        public Lobby(LobbyDataBaseModel lobbyDataBaseModel)
        {
            this.Status = lobbyDataBaseModel.Status;
            this.Players = lobbyDataBaseModel.Players.Select(arg => new Player(arg)).ToList();
            this.LobbyGuid = lobbyDataBaseModel.LobbyName;
            this.Count = lobbyDataBaseModel.Count;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.Status Status { get; set; }

        public List<Player> Players { get; set; }

        public string LobbyGuid { get; set; }

        public int Count { get; set; }
    }
}