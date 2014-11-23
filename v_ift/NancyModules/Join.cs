using System;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Models;

namespace v_ift.NancyModules
{
    public class Join : NancyModule
    {
        public Join()
        {

            Post["/join/{lobby_id}", true] = async (x, ct) =>
            {
                var ready = this.Bind<Models.Join>();



                var join = new ResponseModels.Player();
                join.Name = "";
                join.Guid = new Guid();
                return Response.AsJson(join);
                //return new Response {StatusCode = HttpStatusCode.OK};
            };
        }
    }
}