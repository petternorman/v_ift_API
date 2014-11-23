using System;
using Newtonsoft.Json;
using v_ift.Models;

namespace v_ift.ResponseModels
{
    public class Player
    {
        public Player(PlayerDataModel player)
        {
            this.Name = player.Name;
            this.Id = player.Id;
            this.IsReady = player.IsReady;
            this.Distance = player.Distance;
        }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "isready")]
        public bool IsReady { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public decimal Distance { get; set; }
    }
}