using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lifeline_Care_Hospital.Startup))]
namespace Lifeline_Care_Hospital
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
