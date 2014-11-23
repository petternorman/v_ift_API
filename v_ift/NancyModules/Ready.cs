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
        public Ready(Repository repository)
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
                var player = lobby.Players.FirstOrDefault(arg => arg.Guid.Equals(request.PlayerId));

                if (player == null)
                {
                    return null;
                }

                // sätt spelaren till ready
                player.IsReady = true;

                // uppdaterad lobby 
                var countReadyPlayers = lobby.Players.Count(arg => arg.IsReady);
                lobby.Status = lobby.Count == countReadyPlayers ? Enums.Status.Ongoing : Enums.Status.Waiting;
                // repository.

                return this.Response.AsJson(lobby);
            };
        }
    }
}