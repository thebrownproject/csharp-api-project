using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Supabase;

namespace Supabase_Minimal_API;

/// <summary>
///  Program entry point. Runs the Program
/// </summary>
internal static class Program
{
    /// <summary>
    /// Main entry point for the Program
    /// </summary>
    /// <param name="args">Any command line arguments called from the command line</param>
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add newtonsoft.Json package
        builder.Services.AddControllers().AddNewtonsoftJson(Options =>
        {
            Options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        });

        var config = builder.Configuration;
        var useSwagger = config.GetValue<bool>("UseSwagger");

        if (useSwagger)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }

        ConfigureSupabase(builder.Services, config);

        var app = builder.Build();

        if (useSwagger)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();

    }

    // Function to configure Supabase
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
