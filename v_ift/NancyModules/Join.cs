using System;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Models;
using v_ift.ResponseModels;
using v_ift.Classes.Repositories;

namespace v_ift.NancyModules
{
    public class Join : NancyModule
    {
        public Join(IRepository repository)
        {
            Post["/join", true] = async (x, ct) => 
            {
                var request = this.Bind<JoinModel>();

                if (request == null)
                {
                    return null;
                }

                var lobbyGuid = request.LobbyGuid;

                var player = new Player()
                {
                    Name = request.Name,
                    Guid = new Guid().ToString()
                };

                var lobby = repository.GetLobby(lobbyGuid);
                var players = lobby.Players;
                players.Add(player);

                var updatedLobby = new Lobby()
                {
                    Status = Enums.Status.Waiting,
                    LobbyGuid = lobbyGuid,
                    Players = players
                };

                return Response.AsJson(updatedLobby);
            };
        }
    }
}