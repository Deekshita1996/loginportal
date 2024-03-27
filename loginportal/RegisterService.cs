using loginportal.AppDB_context;
using Microsoft.EntityFrameworkCore;

namespace loginportal
{
    public class RegisterService
    {
        public static void RegisteredServices(IServiceCollection services, IConfiguration config)
        {
            var data = config["ConnectionStrings:DbConnection"];
            services.AddDbContext<LoginContext>(options => options.UseSqlServer(config["ConnectionStrings:DbConnection"]));
        }
    }
    

}
