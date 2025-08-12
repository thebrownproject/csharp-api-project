# Veterinary Management API

> A modern ASP.NET Core 9.0 web application demonstrating clean architecture patterns with Supabase integration

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=flat&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-512BD4?style=flat&logo=dotnet&logoColor=white)](https://docs.microsoft.com/en-us/aspnet/core/)
[![Supabase](https://img.shields.io/badge/Supabase-3FCF8E?style=flat&logo=supabase&logoColor=white)](https://supabase.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?style=flat&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat&logo=swagger&logoColor=black)](https://swagger.io/)

## 🚀 Overview

This project showcases modern .NET development practices through a veterinary contact management system. Built with ASP.NET Core 9.0 and Supabase, it demonstrates clean architecture principles, RESTful API design, and real-time database integration.

### Key Technical Features

- **Clean Architecture**: Separation of concerns with distinct layers for Controllers, Models, and Contracts
- **Modern .NET**: Built on .NET 9.0 with latest C# 12 features
- **Cloud Database**: Real-time integration with Supabase PostgreSQL
- **API Documentation**: Interactive Swagger/OpenAPI documentation
- **Dependency Injection**: Leverages ASP.NET Core's built-in DI container
- **JSON Handling**: Advanced serialization with Newtonsoft.Json

## 📁 Project Structure

```
├── Controllers/          # API endpoints and business logic
│   ├── VetController.cs     # CRUD operations for veterinarians
│   └── ControllerBoilerplate.cs # Template for new controllers
├── Models/              # Database entity mappings
│   ├── VetModel.cs         # Supabase table mapping
│   └── HealthCheckModel.cs # System health monitoring
├── Contracts/           # Data Transfer Objects (DTOs)
│   └── CreateVetRequest.cs # API request validation models
├── Pages/               # Razor Pages UI (optional frontend)
└── Program.cs           # Application entry point & configuration
```

## 🛠️ Technical Architecture

### Database Layer
- **Supabase Integration**: Direct PostgreSQL connection with real-time capabilities
- **Entity Mapping**: Automatic table-to-class mapping with attributes
- **Type Safety**: Strongly-typed database operations

### API Layer
- **RESTful Design**: Standard HTTP methods with proper status codes
- **Input Validation**: Request DTOs separate from database models
- **Error Handling**: Comprehensive exception management
- **Documentation**: Auto-generated API documentation

### Configuration
- **Environment-based Settings**: Separate configs for development/production
- **Secure Credentials**: Configuration-based connection strings
- **Flexible Deployment**: Easy environment switching

## 📋 API Endpoints

### Veterinarian Management

| Method | Endpoint | Description | Request Body |
|--------|----------|-------------|--------------|
| `POST` | `/vet/{id}` | Create new veterinarian | `CreateVetRequest` |
| `GET` | `/vet/{id}` | Get veterinarian by ID | - |
| `PUT` | `/vet/{id}` | Update veterinarian | `UpdateVetRequest` *(planned)* |
| `DELETE` | `/vet/{id}` | Delete veterinarian | - *(planned)* |

### Sample Request Body
```json
{
  "title": "Dr.",
  "firstName": "John",
  "lastName": "Smith", 
  "email": "john.smith@vetclinic.com",
  "phone": "+1234567890",
  "clinicName": "Downtown Veterinary Clinic",
  "clinicAddress": "123 Main St, City, State 12345"
}
```

## 🚦 Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [Supabase Account](https://supabase.com/) (free tier available)
- IDE: Visual Studio 2022, VS Code, or JetBrains Rider

### Local Setup

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd min-api-project
   ```

2. **Configure Supabase**
   ```bash
   # Create appsettings.Development.json
   {
     "SupabaseUrl": "your-supabase-project-url",
     "SupabaseApiKey": "your-supabase-anon-key",
     "UseSwagger": true,
     "DetailedErrors": true
   }
   ```

3. **Install dependencies**
   ```bash
   dotnet restore
   ```

4. **Run the application**
   ```bash
   # HTTP (recommended for development)
   dotnet run --launch-profile http
   
   # HTTPS 
   dotnet run --launch-profile https
   ```

5. **Access the application**
   - API: http://localhost:5144
   - Swagger UI: http://localhost:5144/swagger
   - Web Interface: http://localhost:5144 (Razor Pages)

## 🗄️ Database Schema

### Veterinarian Table Structure
```sql
CREATE TABLE vet (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    title VARCHAR(10),
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    email VARCHAR(255) UNIQUE,
    phone VARCHAR(20) NOT NULL,
    clinic_name VARCHAR(200),
    clinic_address TEXT,
    created_at TIMESTAMP WITH TIME ZONE DEFAULT NOW(),
    updated_at TIMESTAMP WITH TIME ZONE DEFAULT NOW()
);
```

## 🔧 Development Commands

```bash
# Build the project
dotnet build

# Run with specific profile
dotnet run --launch-profile http    # Port 5144
dotnet run --launch-profile https   # Port 7020

# Add new packages
dotnet add package [PackageName]

# Restore dependencies
dotnet restore
```

## 🌟 Technical Highlights

### Clean Code Practices
- **Separation of Concerns**: Clear distinction between data models, request DTOs, and business logic
- **Dependency Injection**: Leverages ASP.NET Core's built-in container for loose coupling
- **Configuration Management**: Environment-based settings with validation
- **Error Handling**: Proper HTTP status codes and exception management

### Modern .NET Features
- **Minimal APIs**: Lightweight, performance-focused endpoints
- **Record Types**: Immutable data structures where applicable
- **Nullable Reference Types**: Enhanced type safety
- **Global Using Statements**: Reduced code verbosity

### Database Integration
- **Real-time Capabilities**: Supabase real-time subscriptions enabled
- **Automatic Refresh**: Token management handled automatically
- **Type-safe Queries**: Strongly-typed database operations
- **Migration Support**: Schema versioning through Supabase dashboard

## 🚀 Future Enhancements

- [ ] Complete CRUD operations (Update, Delete)
- [ ] Authentication and authorization with JWT
- [ ] Unit and integration testing
- [ ] Docker containerization
- [ ] CI/CD pipeline setup
- [ ] Rate limiting and API versioning
- [ ] Logging and monitoring integration
- [ ] Performance optimization and caching

## 🛡️ Security Features

- Configuration-based secret management
- Input validation and sanitization
- SQL injection protection through ORM
- HTTPS redirection in production
- CORS configuration for cross-origin requests

## 📊 Performance Considerations

- Async/await patterns for non-blocking I/O
- Connection pooling through dependency injection
- JSON serialization optimizations
- Lazy loading where applicable

---

*This project demonstrates proficiency in modern .NET development, cloud database integration, and RESTful API design principles. Built as a portfolio piece to showcase full-stack development capabilities.*
