using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examples.Startup))]
namespace Examples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
