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
            Get["/createLobby"] = parameters =>
            {
                repository.RemoveAllLobbys();

                var lobby = new LobbyDataBaseModel
                {
                    Status = Enums.Status.Waiting,
                    LobbyName = "v_iftlobby0",
                    Players = new List<PlayerDataModel>(),
                    Count = 1
                };

                repository.SaveLobby(lobby);

                 return new Response { StatusCode = HttpStatusCode.OK };
            };
        }
    }
}