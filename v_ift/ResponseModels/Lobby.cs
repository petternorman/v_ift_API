using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using v_ift.Models;

namespace v_ift.ResponseModels
{
    public class Lobby
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.Status Status { get; set; }

        public List<Player> Players { get; set; }

        public string LobbyGuid { get; set; }

        public int Count { get; set; }
    }
}