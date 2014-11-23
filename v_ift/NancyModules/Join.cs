using Nancy;

namespace v_ift.NancyModules
{
    public class Join : NancyModule
    {
        public Join()
        {

            Post["/join", true] = async (x, ct) =>
            {
                var join = new ResponseModels.Join();
                return Response.AsJson(join);
                //return new Response {StatusCode = HttpStatusCode.OK};
            };
        }
    }
}