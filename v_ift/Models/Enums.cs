using System.ComponentModel;

namespace v_ift.Models
{
    public class Enums
    {
        public enum Status
        {
            [Description("Waiting")]
            Waiting,
            [Description("Ongoing")]
            Ongoing,
            [Description("Finish")]
            Finish
        }
    }
}
