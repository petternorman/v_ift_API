using System;
using v_ift.Models;

namespace v_ift.ResponseModels
{
    public class Player
    {
        public Player(PlayerDataModel player)
        {
            this.Name = player.Name;
            this.Guid = player._id.ToString();
            this.IsReady = player.IsReady;
            this.Distance = player.Distance;
        }

        public string Name { get; set; }

        public string Guid { get; set; }

        public bool IsReady { get; set; }

        public decimal Distance { get; set; }
    }
}