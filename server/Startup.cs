namespace Server
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure services
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure middleware
        }
    }
}
