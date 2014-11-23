using System.Linq;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Classes.Repositories;
using v_ift.Models;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
	public class Status : NancyModule
	{
		public Status(IRepository repository)
		{
			Get["/getlobby", true] = async (x, ct) =>
			{
				var request = this.Bind<LobbyModel>();

				if (request == null)
				{
					return null;
				}

				var lobby = repository.GetLobby(request.LobbyId);

				if (lobby == null)
				{
					return new Response {StatusCode = HttpStatusCode.NotFound};
				}

				return Response.AsJson(new Lobby(lobby));
			};
		}
	}
}