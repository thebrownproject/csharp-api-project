# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is an ASP.NET Core 9.0 web application that combines minimal API functionality with Razor Pages. The project integrates Supabase as the backend database service and includes Swagger for API documentation.

## Architecture

- **Framework**: ASP.NET Core 9.0 with .NET 9.0 target framework
- **Database**: Supabase (configured via dependency injection)
- **JSON Serialization**: Newtonsoft.Json with reference loop handling
- **UI**: Razor Pages with Bootstrap, jQuery validation
- **API Documentation**: Swagger/OpenAPI (configurable via `UseSwagger` setting)

### Key Components

- `Program.cs`: Main entry point with service configuration and Supabase setup
- `Pages/`: Razor Pages with code-behind models (Index, Error, Privacy)
- `Pages/Shared/_Layout.cshtml`: Main layout template
- `wwwroot/`: Static assets (CSS, JS, libraries)

### Configuration

- Supabase connection requires `SupabaseUrl` and `SupabaseApiKey` in appsettings
- Swagger UI can be enabled/disabled via `UseSwagger` configuration setting
- Development environment uses `DetailedErrors: true`

## Development Commands

### Build and Run
```bash
dotnet build                    # Build the project
dotnet run                      # Run the application
dotnet run --launch-profile http   # Run with HTTP profile (port 5144)
dotnet run --launch-profile https  # Run with HTTPS profile (port 7020)
```

### Package Management
```bash
dotnet restore                  # Restore NuGet packages
dotnet add package [PackageName] # Add new package reference
```

### Development URLs
- HTTP: http://localhost:5144
- HTTPS: https://localhost:7020

## Key Dependencies

- `Microsoft.AspNetCore.Mvc.NewtonsoftJson` (9.0.8)
- `Newtonsoft.Json` (13.0.3)
- `Supabase` (1.1.1)
- `Swashbuckle.AspNetCore` (9.0.3)

## Namespace Convention

- Root namespace: `min_api_project` (note underscore, not hyphen)
- Program namespace: `Supabase_Minimal_API`
- Pages namespace: `min_api_project.Pages`

## Configuration Notes

- Supabase configuration is required and validated at startup
- Missing Supabase config will throw an exception during service registration
- AutoRefreshToken and AutoConnectRealtime are enabled for Supabase client