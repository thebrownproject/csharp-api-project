using Newtonsoft.Json;
using Supabase;

namespace Supabase_Minimal_API;

internal static class Program
{
    // TODO(human): Refactor the Main method to match teacher's structure
    // Break it into: ConfigureWebAppBuilder, BuildWebApp, and update ConfigureSupabase
    // Also update configuration keys to use "Supabase:Url" and "Supabase:Key"
    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        bool useSwagger = builder.Configuration.GetValue<bool>("UseSwagger");

        ConfigureWebAppBuilder(builder, useSwagger);

        WebApplication app = BuildWebApp(builder, useSwagger);

        app.Run();
    }

    private static void ConfigureWebAppBuilder(WebApplicationBuilder builder, bool useSwagger)
    {
        // Add controllers and configure JSON serialization
        builder.Services.AddControllers().AddNewtonsoftJson(options => 
        { 
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; 
        });
    }

    private static WebApplication BuildWebApp(WebApplicationBuilder builder, bool useSwagger)
    {
        // TODO: Move app configuration here
        return builder.Build();
    }

    private static void ConfigureSupabase(IServiceCollection services, IConfiguration config)
    {
        services.AddScoped(_ =>
        {
            string? url = config.GetValue<string>("SupabaseUrl");
            string? supabasekey = config.GetValue<string>("SupabaseApiKey");

            if (string.IsNullOrWhiteSpace(url) ||
                string.IsNullOrWhiteSpace(supabasekey))
            {
                throw new Exception("Missing Supabase config in appsettings.json");
            }

            SupabaseOptions options = new SupabaseOptions();
            options.AutoRefreshToken = true;
            options.AutoConnectRealtime = true;

            return new Client(url, supabasekey, options);
        });
    }
}
