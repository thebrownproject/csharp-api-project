// Using statements
using Newtonsoft.Json;
using Supabase;

// Namespace
namespace Supabase_Minimal_API;

// Program class
internal static class Program
{
    // Application entry point
    private static void Main(string[] args)
    {
        // Creates the foundation for the application
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // Configures the builder with the necessary services
        bool useSwagger = builder.Configuration.GetValue<bool>("UseSwagger");
        
        // Configures the web app builder
        ConfigureWebAppBuilder(builder, useSwagger);

        // Builds the application
        WebApplication app = BuildWebApp(builder, useSwagger);

        // Runs the application
        app.Run();
    }

    // Configures the web app builder with the necessary services
    private static void ConfigureWebAppBuilder(WebApplicationBuilder builder, bool useSwagger)
    {
        // Add controllers and configure JSON serialization
        builder.Services.AddControllers().AddNewtonsoftJson(options => 
        { 
            // Why? Ignores reference loops in JSON serialization
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; 
        });

        // Configures the Supabase client
        ConfigureSupabase(builder.Services, builder.Configuration);

        // Configures the Swagger UI
        if (useSwagger)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }
    }

    // Configures the Supabase client
    private static void ConfigureSupabase(IServiceCollection services, IConfiguration config)
    {
        // Adds the Supabase client to the DI container
        services.AddScoped(_ =>
        {
            // Gets the Supabase URL and API key from the configuration
            string? url = config.GetValue<string>("SupabaseUrl");
            string? supabasekey = config.GetValue<string>("SupabaseApiKey");

            // Throws an exception if the Supabase URL or API key is missing
            if (string.IsNullOrWhiteSpace(url) ||
                string.IsNullOrWhiteSpace(supabasekey))
            {
                throw new Exception("Missing Supabase config in appsettings.json");
            }

            // Creates a new Supabase client
            SupabaseOptions options = new SupabaseOptions();

            // Sets the options for the Supabase client
            options.AutoRefreshToken = true;

            // Sets the options for the Supabase client
            options.AutoConnectRealtime = true;

            return new Client(url, supabasekey, options);
        });
    }

    // Builds the web application
    private static WebApplication BuildWebApp(WebApplicationBuilder builder, bool useSwagger)
    {
        // Builds the web application
        WebApplication app = builder.Build();

        // Configures the web application
        if (useSwagger)
        {
            // Enables Swagger
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Redirects to HTTPS
        app.UseHttpsRedirection();

        // Uses the controllers
        app.UseAuthorization();

        // Uses the controllers
        app.MapControllers();

        // Returns the web application
        return app;
    }
}
