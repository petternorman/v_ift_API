using System;
using System.Collections.Generic;
using v_ift.Models;

namespace v_ift.ResponseModels
{
    public class Lobby
    {
        public Enums.Status Status { get; set; }

        public List<Player> Players { get; set; }

        public Guid LobbyGuid { get; set; }
    }
}