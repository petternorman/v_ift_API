using System.Collections.Generic;
using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace v_ift.Models
{
    public class LobbyDataBaseModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.Status Status { get; set; }

        public List<PlayerDataModel> Players { get; set; }

        public string LobbyName { get; set; }

        public int Count { get; set; }

        public ObjectId _id { get; set; }

        public decimal Distance { get; set; }
    }
}