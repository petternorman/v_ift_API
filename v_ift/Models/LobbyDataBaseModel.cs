using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using v_ift.ResponseModels;

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

        public double Distance { get; set; }
    }
}