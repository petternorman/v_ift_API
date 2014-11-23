using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Models;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
    public class Ready : NancyModule
    {
        public Ready()
        {
            Post["/ready", true] = async (x, ct) =>
            {
                var ready = this.Bind<ReadyModel>();

                var players = new List<Player>()
                {
                    new Player { Guid = new Guid(), Name = "Sandra", IsReady = true }
                };

                var status = new Lobby()
                {
                    Status = Enums.Status.Waiting,
                    LobbyGuid = new Guid(),
                    Players = players
                };

                return this.Response.AsJson(status);
            };
        }
    }
}