using System;
using System.Collections.Generic;

namespace v_ift.Models
{
    public class PlayerDataModel
    {
        public string Name { get; set; }

        public Guid Guid { get; set; }

        public bool IsReady { get; set; }

        public decimal Distance { get; set; }

        public List<Coordinate> Coordinates { get; set; }
    }
}