using System.Collections.Generic;
using Nancy;
using v_ift.Classes.Repositories;
using v_ift.Models;

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