using Nancy;
using v_ift.Classes;

namespace v_ift.NancyModules
{
	public class Test : NancyModule
	{
		private readonly IDatabaseHelper _databaseHelper;

		public Test(IDatabaseHelper databaseHelper)
		{
			_databaseHelper = databaseHelper;
		}

		public void TestDB()
		{
			var database = _databaseHelper.GetMongoDatabase();
		}
	}

}