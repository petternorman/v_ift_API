using System;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Classes;
using v_ift.Models;
using v_ift.ResponseModels;
using v_ift.Classes.Repositories;

namespace v_ift.NancyModules
{
    public class Join : NancyModule
    {
        public Join()
        {
            Post["/join", true] = async (x, ct) => 
            {
                IDatabaseHelper databaseHelper = new DatabaseHelper();

                var respository = new Repository(databaseHelper);

                var join = this.Bind<JoinModel>();

                var lobbyGuid = join.LobbyGuid;

                var player = new Player()
                {
                    Name = join.Name,
                    Guid = new Guid()
                };

                var lobby = respository.GetLobby(lobbyGuid);
                var players = lobby.Players;
                players.Add(player);

                var status = new Lobby()
                {
                    Status = Enums.Status.Waiting,
                    LobbyGuid = lobbyGuid,
                    Players = players
                };

                return Response.AsJson(status);
            };
        }
    }
}