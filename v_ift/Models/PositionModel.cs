using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace v_ift.Models
{
    public class PositionModel
    {
        public Guid LobbyId { get; set; }

        public Guid PlayerId { get; set; }

        public int Long { get; set; }

        public int Lat { get; set; }
    }
}