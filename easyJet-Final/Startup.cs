using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace easyJet_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
