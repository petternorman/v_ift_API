using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Models;

namespace v_ift.NancyModules
{
    public class Ready : NancyModule
    {
        public Ready()
        {
            Post["/ready", true] = async (x, ct) =>
            {
                var ready = this.Bind<ReadyModel>();

                return new Response { StatusCode = HttpStatusCode.OK };
            };
        }
    }
}