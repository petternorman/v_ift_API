using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Classes.Repositories;
using v_ift.Models;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
    public class Ready : NancyModule
    {
        public Ready(IRepository repository)
        {
            Post["/ready", true] = async (x, ct) =>
            {
                var request = this.Bind<ReadyModel>();

                if (request == null)
                {
                    return null;
                }

                // hämta upp rummet. 
                var lobby = repository.GetLobby(request.LobbyId);

                if (lobby == null)
                {
                    return new Response { StatusCode = HttpStatusCode.NotFound };
                }

                var player = lobby.Players.FirstOrDefault(arg => arg.Id.Equals(request.PlayerId));

                if (player == null)
                {
                    return new Response { StatusCode = HttpStatusCode.NotFound };
                }

                // sätt spelaren till ready
                player.IsReady = true;

                // uppdaterad lobby 
                var countReadyPlayers = lobby.Players.Count(arg => arg.IsReady);
                lobby.Status = lobby.Count == countReadyPlayers ? Enums.Status.Ongoing : Enums.Status.Waiting;

                var respone = new Lobby(lobby, player.Id);

                repository.SaveLobby(lobby);

                return this.Response.AsJson(respone);
            };
        }
    }
}