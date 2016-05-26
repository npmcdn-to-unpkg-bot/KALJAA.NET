using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.FileProviders;

public class Startup
{
    public Startup(IHostingEnvironment env)
    {
        _env = env;
    }
    
    private IHostingEnvironment _env;

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, IHostingEnvironment environment)
    {
        app.UseDefaultFiles();
        
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(@"C:\github\KALJAA.NET\node_modules"),
            RequestPath = "/node_modules", 
        });
        
        app.UseStaticFiles();
    }
}