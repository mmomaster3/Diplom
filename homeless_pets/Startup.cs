using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(homeless_pets.Startup))]
namespace homeless_pets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
