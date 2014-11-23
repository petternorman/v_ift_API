using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace v_ift.Models
{
    public class PlayerDataModel
    {
        public string Name { get; set; }

        public bool IsReady { get; set; }

        public decimal Distance { get; set; }

        public List<Coordinate> Coordinates { get; set; }

        public ObjectId _id { get; set; }
    }
}