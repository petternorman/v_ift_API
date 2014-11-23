using System;

namespace v_ift.ResponseModels
{
    public class Player
    {
        public string Name { get; set; }

        public Guid Guid { get; set; }

        public bool IsReady { get; set; }
    }
}