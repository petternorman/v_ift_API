using Nancy;
using Nancy.TinyIoc;
using v_ift.Classes;

namespace v_ift.Bootstrap
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
		protected override void ConfigureApplicationContainer(TinyIoCContainer container)
		{
			container.Register<IDatabaseHelper, DatabaseHelper>();

		}
    }
}