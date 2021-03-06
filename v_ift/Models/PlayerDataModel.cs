﻿using System.Collections.Generic;

namespace v_ift.Models
{
    public class PlayerDataModel
    {
        public string Name { get; set; }

        public bool IsReady { get; set; }

        public bool IsWinner { get; set; }

        public decimal Distance { get; set; }

        public List<Coordinate> Coordinates { get; set; }

        public string Id { get; set; }
    }
}