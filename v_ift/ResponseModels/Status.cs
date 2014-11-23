using System;
using System.Collections.Generic;

namespace v_ift.ResponseModels
{
    public class Status
    {
        public List<Player> Players { get; set; }
        public Guid LobbyGuid{ get; set; }
    }
}