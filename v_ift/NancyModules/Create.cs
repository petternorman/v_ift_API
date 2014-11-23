using Nancy;

namespace v_ift.NancyModules
{
    public class Create : NancyModule
    {
        public Create()
        {
            Post["/join", true] = async (x, ct) =>
            {

                return new Response {StatusCode = HttpStatusCode.OK};
            };
        }
    }
}