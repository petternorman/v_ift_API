using System;
using v_ift.ResponseModels;

namespace v_ift.Classes.Repositories
{
	public interface IRepository
	{
		Player GetPlayer(Guid id);
		Lobby GetLobby(Guid id);
		bool SavePlayer(Player player);
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
			return null;
		}

		public Lobby GetLobby(Guid id)
		{
			return null;
		}

		public bool SavePlayer(Player player)
		{
			return false;
		}
	}
}