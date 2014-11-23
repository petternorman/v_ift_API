using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v_ift.Models
{
    public class PositionModel
    {
        public string LobbyId { get; set; }

        public string PlayerId { get; set; }

        public int Lng { get; set; }

        public int Lat { get; set; }
    }
}