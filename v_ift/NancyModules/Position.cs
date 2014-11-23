using v_ift.Classes.Repositories;
using v_ift.Models;
using Nancy;
using Nancy.ModelBinding;

namespace v_ift.NancyModules
{
    public class Position : NancyModule
    {
        public Position(Repository repository)
        {
            Post["/ready", true] = async (x, ct) =>
            {
                var request = this.Bind<PositionModel>();

                if (request == null)
                {
                    return null;
                }

                // spara ner nya kordinater för spelaren

                // räkna ut avståndet

                // skicka spelaren 

                return null;

            };
        }
    }
}