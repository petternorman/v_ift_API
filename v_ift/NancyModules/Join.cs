using System;
using System.Collections.Generic;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Models;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
    public class Join : NancyModule
    {
        public Join()
        {

            Post["/join/{lobby_id}", true] = async (x, ct) =>
            {
                var join = this.Bind<JoinModel>();

                var player = new ResponseModels.Player()
                {
                    Name = join.Name,
                    Guid = new Guid()
                };

                var lobbyGuid = new Guid();
                var players = new List<Player>();

                var status = new Lobby()
                {
                    Status = Enums.Status.Waiting,
                    LobbyGuid = lobbyGuid,
                    Players = players
                };

                return Response.AsJson(status);
                //return new Response {StatusCode = HttpStatusCode.OK};
            };
        }
    }
}