using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Challenge_36_Hero_Monster.Startup))]
namespace Challenge_36_Hero_Monster
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
