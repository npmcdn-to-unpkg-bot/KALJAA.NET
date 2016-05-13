
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.StaticFiles;
using Microsoft.AspNet.FileProviders;

namespace Carpax.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            _env = env;
        }
        
        private IHostingEnvironment _env;
    
        public void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerfactory, IHostingEnvironment environment)
        {
            loggerfactory.AddConsole();
            
            app.UseDefaultFiles();
            
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(@"C:\github\KALJAA.NET\node_modules"),
                RequestPath = "/node_modules", 
            });
            
            app.UseStaticFiles();
        }

        public static void Main(string[] args) =>
            WebApplication.Run<Startup>(args);
    }
}
