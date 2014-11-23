using Newtonsoft.Json;

namespace v_ift.Models
{
	public class LobbyModel
	{
		[JsonProperty(PropertyName = "lobbyId")]
		public string LobbyId { get; set; }
	}
}