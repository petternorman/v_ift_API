using System.Linq;
using MongoDB.Driver.Linq;
using v_ift.Models;
using v_ift.ResponseModels;

namespace v_ift.Classes.Repositories
{
	public interface IRepository
	{
		Player GetPlayer(string id);
		LobbyDataBaseModel GetLobby(string id);
		void SavePlayer(Player player);
		void SaveLobby(LobbyDataBaseModel lobby);
	}

	public class Repository : IRepository
	{
		private readonly IDatabaseHelper _databaseHelper;

		public Repository(IDatabaseHelper databaseHelper)
		{
			_databaseHelper = databaseHelper;
		}

		public Player GetPlayer(string id)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<Player>("Players");
			return collection.AsQueryable<Player>().FirstOrDefault(p => p.Id == id);

		}

		public LobbyDataBaseModel GetLobby(string id)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<LobbyDataBaseModel>("Lobbies");
			return collection.AsQueryable<LobbyDataBaseModel>().FirstOrDefault(l => l.LobbyName == id);
		}

		public void SavePlayer(Player player)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<Player>("Players");
			collection.Save(player);
		}

		public void SaveLobby(LobbyDataBaseModel lobby)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<LobbyDataBaseModel>("Lobbies");
			collection.Save(lobby);
		}
	}
}