using System;

namespace v_ift.ResponseModels
{
    public class Player
    {
        public string Name { get; set; }

        public string Guid { get; set; }

        public bool IsReady { get; set; }

        public decimal Distance { get; set; }
    }
}