using Nancy;
using Nancy.TinyIoc;
using v_ift.Classes;
using v_ift.Classes.Repositories;

namespace v_ift.Bootstrap
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
		protected override void ConfigureApplicationContainer(TinyIoCContainer container)
		{
			container.Register<IDatabaseHelper, DatabaseHelper>();
			container.Register<IRepository, Repository>();

            container.Register<ICalculateDistance, CalculateDistance>();

            container.Register<CalculateDistance, CalculateDistance>();
		}
    }
}