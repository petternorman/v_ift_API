using Nancy;
using v_ift.Classes.Repositories;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
	public class Status : NancyModule
	{
		public Status(IRepository repository)
		{
			Get["/getlobby/{lobbyId}"] = parameters =>
			{
				var lobby = repository.GetLobby(parameters.lobbyId);
				return FormatterExtensions.AsJson(this.Response, new Lobby(lobby));
			};
		}
	}
}