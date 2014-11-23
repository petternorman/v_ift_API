using System.Configuration;
using MongoDB.Driver;

namespace v_ift.Classes
{
	public interface IDatabaseHelper
	{
		MongoDatabase GetMongoDatabase();
	}

	public class DatabaseHelper : IDatabaseHelper
	{
		public MongoDatabase GetMongoDatabase()
		{
			var connectionstring = ConfigurationManager.AppSettings.Get("(MONGOHQ_URL|MONGOLAB_URI)");
			var url = new MongoUrl(connectionstring);
			var client = new MongoClient(url);
			var server = client.GetServer();
			var database = server.GetDatabase(url.DatabaseName);
			return database;
		}
	}
}