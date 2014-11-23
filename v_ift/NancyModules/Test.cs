using System.Configuration;
using MongoDB.Driver;
using Nancy;

namespace v_ift.NancyModuls
{
	public class Test : NancyModule
	{
		public MongoDatabase Database
		{
			get
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

}