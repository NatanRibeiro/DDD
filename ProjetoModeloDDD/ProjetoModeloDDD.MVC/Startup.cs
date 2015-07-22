using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoModeloDDD.MVC.Startup))]
namespace ProjetoModeloDDD.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
