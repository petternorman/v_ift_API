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
    public class CreateLobby : NancyModule
    {
        public CreateLobby(IRepository repository)
        {
            Post["/createLobby", true] = async (x, ct) =>
            {
                var lobby = new LobbyDataBaseModel
                {
                    Status = Enums.Status.Waiting,
                    LobbyName = "v_iftlobby",
                    Players = new List<PlayerDataModel>()
                };

                repository.SaveLobby(lobby);

                 return new Response { StatusCode = HttpStatusCode.NotFound };
            };
        }
    }
}