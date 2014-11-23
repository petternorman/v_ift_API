using System.Linq;
using v_ift.Classes;
using v_ift.Classes.Repositories;
using v_ift.Models;
using Nancy;
using Nancy.ModelBinding;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
    public class Position : NancyModule
    {
        public Position(Repository repository, ICalculateDistance calculateDistance)
        {
            Post["/position", true] = async (x, ct) =>
            {
                var request = this.Bind<PositionModel>();

                if (request == null)
                {
                    return null;
                }

                var lobby = repository.GetLobby(request.LobbyId);
                var player = lobby.Players.FirstOrDefault(arg => arg.Id.ToString() == request.PlayerId);

                player.Coordinates.Add(new Coordinate(request.Lat, request.Lng));

                var distance = calculateDistance.GetDistanceBetween(player.Coordinates);
                player.Distance = distance;
                repository.SaveLobby(lobby);

                return this.Response.AsJson(new Lobby(lobby));
            };
        }
    }
}