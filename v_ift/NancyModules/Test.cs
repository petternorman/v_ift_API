using Nancy;

namespace v_ift.NancyModules
{
    public class Test : NancyModule
    {
        public Test()
        {
            this.Get["/test/{id}/}"] = parameters =>
            {
                return new Response {StatusCode = HttpStatusCode.OK};
            };
        }
    }
}