using System;
using System.Linq;
using MongoDB.Driver.Linq;
using v_ift.ResponseModels;

namespace v_ift.Classes.Repositories
{
	public interface IRepository
	{
		Player GetPlayer(Guid id);
		Lobby GetLobby(Guid id);
		void SavePlayer(Player player);
	}

	public class Repository : IRepository
	{
		private readonly IDatabaseHelper _databaseHelper;

		public Repository(IDatabaseHelper databaseHelper)
		{
			_databaseHelper = databaseHelper;
		}

		public Player GetPlayer(Guid id)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<Player>("Players");
			return collection.AsQueryable<Player>().FirstOrDefault(p => p.Guid == id);

		}

		public Lobby GetLobby(Guid id)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<Lobby>("Lobbies");
			return collection.AsQueryable<Lobby>().FirstOrDefault(l => l.LobbyGuid == id);
		}

		public void SavePlayer(Player player)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<Player>("Players");
			collection.Insert(player);
		}
	}
}