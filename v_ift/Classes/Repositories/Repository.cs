﻿using System;
using System.Linq;
using MongoDB.Driver.Linq;
using v_ift.ResponseModels;

namespace v_ift.Classes.Repositories
{
	public interface IRepository
	{
		Player GetPlayer(string id);
		Lobby GetLobby(string id);
		void SavePlayer(Player player);
		void SaveLobby(Lobby lobby);
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
			return collection.AsQueryable<Player>().FirstOrDefault(p => p.Guid == id);

		}

		public Lobby GetLobby(string id)
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

		public void SaveLobby(Lobby lobby)
		{
			var db = _databaseHelper.GetMongoDatabase();
			var collection = db.GetCollection<Lobby>("Lobbies");
			collection.Insert(lobby);
		}
	}
}