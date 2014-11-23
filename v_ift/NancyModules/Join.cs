using System;
using System.Collections.Generic;
using MongoDB.Bson;
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

                var player = new PlayerDataModel()
                {
                    Name = request.Name 
                };

                var lobby = repository.GetLobby(request.LobbyId);

                if (lobby == null)
                {
                    return new Response { StatusCode = HttpStatusCode.NotFound };
                }

                var players = lobby.Players;
                
                players.Add(player);
                repository.SaveLobby(lobby);

                return Response.AsJson(new Lobby(lobby));
            };
        }
    }
}