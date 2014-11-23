using System;
using System.Collections.Generic;
using v_ift.Models;

namespace v_ift.ResponseModels
{
    public class Player
    {
        public string Name { get; set; }

        public Guid Guid { get; set; }

        public bool IsReady { get; set; }

        public List<Coordinate> Coordinates{ get; set; }
    }
}