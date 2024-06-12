// Startup.cs
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BlogApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<BlogDbContext>(opt =>
                opt.UseInMemoryDatabase("BlogDb"));
        }
    }
}