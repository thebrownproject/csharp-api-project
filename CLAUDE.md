# CLAUDE.md

This file provides comprehensive guidance to Claude Code when working with this ASP.NET Core project based on the Claude Code Master Template. It contains essential template context and buildable sections that grow with your project.

## Template Foundation

### 🎯 **What This Template Provides**

- **Integrated AI Development Methodologies**: Ready for BMAD Method and modern AI-assisted development
- **MCP Server Integration**: 7 pre-configured servers for enhanced development capabilities
- **Context7 Documentation Management**: Intelligent local-first documentation caching and retrieval
- **Serena Semantic Analysis**: Token-efficient code navigation and intelligent editing workflows
- **BMAD Method**: Pre-installed agentic development methodology with planning and implementation phases

### 🛠️ **Core MCP Server Integrations**

- **Context7**: Documentation retrieval with local caching (`/context7:*` commands)
- **Serena**: Precision semantic targeting after Gemini bulk analysis (Tier 3 in optimization strategy)
- **Playwright**: AI-powered browser automation using accessibility trees
- **Sequential-thinking**: Structured problem-solving with dynamic thought processes
- **Supabase**: Complete database and project management
- **Brave Search**: Comprehensive web search with fresh results
- **Gemini CLI**: Leverage Gemini's massive context window for large-scale analysis

### 🔄 **Core Development Methodologies**

- **BMAD Method**: Agentic planning (Analyst, PM, Architect) → Development (SM, Dev, QA)
- **Three-Tier Workflows**: Built-ins → Gemini CLI → Serena → Claude Code edits → User reviews
- **Token Optimization**: Strategic tool selection, Gemini's massive context, local-first documentation
- **Context7 Strategy**: Build comprehensive local documentation cache over time

## 🚨 CLAUDE.md Final File Size Requirements

**MANDATORY LIMITS (DO NOT REMOVE THIS SECTION):**

- **Maximum:** 700 lines (HARD LIMIT)
- **Preferred:** 450-600 lines (TARGET RANGE)

**Guidelines for Filling TODO Sections:**

- Keep each section concise and focused
- Use bullet points, not long paragraphs
- Focus on essential information Claude needs
- Move detailed documentation to separate files
- Every line consumes tokens on every interaction

**Token Budget Impact:**

- Bloated files = higher costs
- Too much content = reduced Claude effectiveness
- Aim for "lean and intentional" documentation

## Universal Development Principles

### Core Philosophy

- **KISS (Keep It Simple, Stupid)**: Choose straightforward solutions over complex ones
- **YAGNI (You Aren't Gonna Need It)**: Implement features only when needed
- **Fail Fast**: Check for errors early and raise exceptions immediately
- **Single Responsibility**: Each function, class, and module should have one clear purpose

### File and Code Organization

- **Files**: Never exceed 500 lines of code - refactor by splitting into modules
- **Functions**: Keep under 50 lines with single, clear responsibility
- **Classes**: Under 100 lines representing a single concept
- **Line Length**: Maximum 100 characters (adaptable per language)
- **Modules**: Organize by feature or responsibility, not technical layers

### Testing Philosophy

- **Test-Driven Development**: Write tests first, watch them fail, implement minimal code
- **Test Organization**: Keep tests close to the code they test
- **Coverage**: Aim for 80%+ but focus on critical paths
- **Test Types**: Unit (isolation) → Integration (components) → End-to-end (workflows)

### Error Handling

- **Custom Exceptions**: Create domain-specific exception hierarchies
- **Specific Handling**: Catch specific exceptions, not broad catches
- **Resource Management**: Use context managers for cleanup
- **Logging**: Structured logging with appropriate levels

### Security Guidelines

- **Never commit secrets**: Use environment variables and configuration management
- **Input Validation**: Validate all user input at boundaries
- **Parameterized Queries**: Never concatenate user input into queries
- **Dependencies**: Keep updated and monitor for vulnerabilities
- **Authentication**: Implement proper auth/authz patterns

### Git Workflow

- **Branch Strategy**: `main` (production) ← PR ← `feature/*`, `fix/*`, `docs/*`
- **Commit Messages**: `<type>(<scope>): <subject>` format
- **Never include**: "claude code" or "written by claude" in commit messages
- **Daily Flow**: checkout main → pull → create feature branch → develop → PR → merge

## 📚 Context7 Documentation Management Strategy

**🚨 CRITICAL: Always check local documentation cache before writing any new code!**

#### Available Commands & Token Savings

- **`/context7:retrieve-docs`** - Fetch fresh docs from Context7 and cache in `.claude/docs/`
- **`/context7:read-docs`** - Read from local cache first (90% token savings vs MCP calls)
- **`/context7:list-docs`** - View cached documentation inventory
- **`/context7:refresh-docs`** - Update specific cached docs with fresh versions

#### Local Documentation Structure

`.claude/docs/` organization:

- `libraries/` - Third-party library docs (e.g., `aspnet-core-2024-08-16.md`)
- `apis/` - API documentation and schemas (e.g., `supabase-dotnet-2024-08-12.md`)
- `guides/` - Development guides and tutorials
- `project/` - Project-specific documentation

#### Mandatory Pre-Coding Workflow

**Before writing any new code, ALWAYS follow this sequence:**

1. **`/context7:list-docs`** - Check what's cached locally
2. **`/context7:read-docs [library]`** - Review relevant docs from cache
3. **`/context7:retrieve-docs [missing]`** - Fetch any missing documentation
4. **Build understanding** from documentation patterns and APIs
5. **Write code** following documented patterns

## 🚀 Project Overview

This is an ASP.NET Core 9.0 minimal API application for veterinary practice management. The project integrates Supabase as the backend database service with comprehensive Swagger documentation. The application manages veterinary contacts and follows clean architecture principles with dependency injection.

**Key Goals:**
- Veterinary practice management (vet contacts, clinic information)
- Modern ASP.NET Core minimal API patterns
- Supabase integration for PostgreSQL backend
- Clean, testable, and scalable architecture

**Current Domain:**
- Vet contact management with clinic details
- CRUD operations for veterinary professionals
- Supabase PostgreSQL backend with real-time capabilities

## 🛠️ Technology Stack

### Core Framework
- **ASP.NET Core 9.0** with .NET 9.0 target framework
- **Minimal API** architecture with controller-based routing
- **Dependency Injection** for service management

### Database & Backend Services
- **Supabase** (1.1.1) - PostgreSQL-based backend-as-a-service
- **Supabase .NET Client** with auto-refresh tokens and realtime capabilities

### JSON & Serialization
- **Newtonsoft.Json** (13.0.3) for JSON serialization
- **Microsoft.AspNetCore.Mvc.NewtonsoftJson** (9.0.8) for MVC integration
- **Reference loop handling** configured

### API Documentation
- **Swagger/OpenAPI** via Swashbuckle.AspNetCore (9.0.3)
- **Interactive API documentation** with configurable UI

### Development Tools
- **.NET CLI** for project management and build operations
- **NuGet** package management with hot reload support

## 📁 Project Structure

```
min-api-project/
├── Controllers/            # API controllers
│   ├── VetController.cs   # Veterinary management endpoints
│   └── ControllerBoilerplate.cs
├── Models/                # Data models and DTOs
│   ├── VetModel.cs       # Veterinary professional model
│   └── HealthCheckModel.cs
├── Contracts/             # API request/response contracts
│   └── CreateVetRequest.cs
├── Validation/            # Input validation logic
│   └── ValidationBoilerplate.cs
├── Pages/                 # Razor Pages for UI
│   ├── Index.cshtml      # Home page
│   ├── Privacy.cshtml    # Privacy policy
│   ├── Error.cshtml      # Error handling
│   └── Shared/           # Shared layouts and partials
├── wwwroot/              # Static web assets
│   ├── css/              # Stylesheets
│   ├── js/               # JavaScript files
│   └── lib/              # Client-side libraries (Bootstrap, jQuery)
├── Properties/           # Launch settings and configuration
├── bin/                  # Compiled binaries (auto-generated)
├── obj/                  # Build artifacts (auto-generated)
├── Program.cs            # Application entry point and configuration
├── min-api-project.csproj # Project file and dependencies
├── appsettings.json      # Application configuration
├── appsettings.Development.json # Development overrides
└── CLAUDE.md             # Project documentation and guidance
```

### Key Organization Principles
- **Feature-based Controllers**: Each controller represents a business domain (Vet management)
- **Clean Separation**: Models, contracts, and validation are separated for maintainability
- **ASP.NET Core Conventions**: Following standard .NET project structure
- **Static Assets**: wwwroot contains all client-side resources
- **Configuration Separation**: Environment-specific settings in separate files

### Where to Place New Files
- **New API endpoints**: Add controllers to `Controllers/` directory
- **Data models**: Place in `Models/` with clear, descriptive names
- **Request/Response types**: Add to `Contracts/` for API boundary definitions
- **Business logic**: Create `Services/` directory for complex operations
- **Database entities**: Consider `Entities/` separate from DTOs in `Models/`
- **Validation rules**: Extend `Validation/` directory with domain-specific validators

## 🏗️ Architecture

### Current Structure
- **Program.cs**: Main entry point with Supabase setup and middleware pipeline
- **Controllers/**: VetController for veterinary management APIs
- **Models/**: VetModel and HealthCheckModel for data representation
- **Contracts/**: CreateVetRequest for API contracts
- **Validation/**: Validation boilerplate for input validation
- **Pages/**: Razor Pages for future UI expansion

### Data Flow
1. **HTTP Request** → ASP.NET Core middleware pipeline
2. **Controller** → Action method with model binding
3. **Supabase Client** → Direct database operations
4. **Response** → JSON serialization and HTTP response

### External Integrations
- **Supabase API**: PostgreSQL database with vet table schema
- **Swagger UI**: Interactive API documentation at `/swagger`

## 📋 Development Environment & Configuration

### Prerequisites
- **.NET 9.0 SDK** or later
- **Visual Studio Code** with C# extension
- **Supabase Account** for database services

### Setup
```bash
git clone [repository-url]
cd min-api-project
dotnet restore
dotnet run
```

### Configuration (appsettings.json)
```json
{
  "SupabaseUrl": "your-supabase-url",
  "SupabaseApiKey": "your-supabase-anon-key",
  "UseSwagger": true
}
```

### Development URLs
- **HTTP**: http://localhost:5144
- **HTTPS**: https://localhost:7020
- **Swagger UI**: https://localhost:7020/swagger

## 🔧 Language-Specific Tooling

### Package Management
- **NuGet**: .NET package manager (`dotnet add package`, `dotnet restore`)
- **Version Management**: Centralized in .csproj file

### Code Quality
- **EditorConfig**: Code style enforcement across IDEs
- **Roslyn Analyzers**: Static code analysis and style rules

### Testing Frameworks (Future)
- **xUnit**: Primary testing framework for .NET
- **Moq**: Mocking framework for unit tests
- **FluentAssertions**: Readable assertion library

### Build Systems
- **.NET CLI**: Primary build and development tool
- **dotnet watch**: Hot reload during development

## 🧪 Testing Strategy

### Testing Approach (To Implement)
- **Unit Testing**: xUnit for controller and service testing
- **Integration Testing**: TestServer for API integration tests
- **Database Testing**: Supabase test environment
- **Coverage**: Target 80%+ with Coverlet

### Test Organization
- Separate test projects following naming conventions
- Test fixtures for reusable test data setup
- Mocking with Moq for dependency isolation

## 📚 API Documentation

### Swagger Integration
- **Automatic Generation**: Schema generation from controller actions
- **Interactive UI**: Swagger UI for exploration and testing
- **Configuration**: Conditionally enabled via `UseSwagger` setting

### Current Endpoints
- **Vet Management**: CRUD operations for veterinary contacts
- **Health Checks**: Application health monitoring endpoints

### Documentation Standards
- **XML Comments**: Comprehensive documentation for all public APIs
- **Error Codes**: Documented HTTP status codes and responses

## 🚀 Deployment

### Build Commands
```bash
dotnet clean
dotnet restore
dotnet build --configuration Release
dotnet test
dotnet publish -c Release
```

### Environment Variables for Production
- **SUPABASE_URL**: Production Supabase project URL
- **SUPABASE_API_KEY**: Production Supabase key
- **ASPNETCORE_ENVIRONMENT**: Environment identifier
- **USE_SWAGGER**: Swagger enablement flag

## 📖 Project-Specific Guidelines

### Code Style
- **C# Conventions**: Follow Microsoft C# coding conventions
- **Naming**: PascalCase for public members, camelCase for parameters
- **File Organization**: One class per file, namespace matches folder structure

### ASP.NET Core Patterns
- **Controller Design**: Thin controllers with business logic in services
- **Dependency Injection**: Constructor injection with interface abstractions
- **Configuration**: Options pattern for strongly-typed configuration

### Performance Guidelines
- **Async/Await**: Use async patterns for I/O operations
- **Memory Management**: Dispose resources properly
- **Database Access**: Optimize Supabase queries with proper pagination

## 🔗 Dependencies

### Core Dependencies
- **Microsoft.AspNetCore.Mvc.NewtonsoftJson** (9.0.8): MVC integration
- **Newtonsoft.Json** (13.0.3): JSON serialization with reference loop handling
- **Supabase** (1.1.1): PostgreSQL backend client
- **Swashbuckle.AspNetCore** (9.0.3): OpenAPI/Swagger documentation

### Dependency Selection Criteria
- **Active Maintenance**: Regular updates and community support
- **Performance**: Minimal impact on application performance
- **Compatibility**: Works well with ASP.NET Core and .NET 9.0

## 🛠️ Development Tools & Commands

### Core Commands
```bash
dotnet restore                      # Restore NuGet packages
dotnet build                        # Build the project
dotnet run                          # Run application
dotnet watch run                    # Run with hot reload
dotnet test                         # Run all tests
dotnet format                       # Format code
```

### Package Management
```bash
dotnet add package [PackageName]    # Add package reference
dotnet list package                 # List installed packages
dotnet list package --outdated      # Check for updates
```

### Development Tools
- **Visual Studio Code**: Primary development environment
- **Swagger UI**: API testing and documentation
- **Supabase Dashboard**: Database management interface

## Namespace Convention

- **Root namespace**: `min_api_project` (note underscore, not hyphen)
- **Program namespace**: `Supabase_Minimal_API`
- **Controllers namespace**: `min_api_project.Controllers`
- **Models namespace**: `min_api_project.Models`

## Configuration Notes

- **Supabase configuration is required and validated at startup**
- **Missing Supabase config will throw exception during service registration**
- **AutoRefreshToken and AutoConnectRealtime enabled for Supabase client**
- **Controllers configured with Newtonsoft.Json for reference loop handling**
- **HTTPS redirection and authorization middleware enabled**

## Three-Tier Token Optimization Strategy

**MANDATORY: Follow this escalation strategy for maximum token efficiency**

### **Tier 1: Claude Code Built-ins** (Start Here)
- **Tools**: `Grep`, `Glob`, `Read`, `LS`
- **Use for**: Small projects, known file locations, simple pattern searches
- **Cost**: Free/minimal token usage

### **Tier 2: Gemini CLI** (Scale Up for Large Analysis)
- **Massive Context**: 1M+ token window for bulk analysis
- **Use for**: Large codebase exploration, architectural understanding, "analyze entire codebase" queries
- **Strategy**: Leverage Gemini's generous context limits to save Claude Code tokens
- **Perfect for**: Planning phases, comprehensive code reviews, alternative perspectives

### **Tier 3: Serena MCP** (Precision Targeting)
- **Use for**: Precise symbol-level navigation when Gemini identifies specific targets
- **Tools**: `search_for_pattern`, `get_symbols_overview`, `find_symbol`, `write_memory`
- **Strategy**: Semantic analysis without full file reads after Gemini bulk discovery

### **Decision Matrix**
- **Small/Medium projects**: Tier 1 → Direct Claude Code editing
- **Large codebases**: Tier 2 (Gemini bulk) → Tier 3 (Serena precision) → Claude Code editing
- **Unknown structure**: Tier 2 exploration → Tier 3 navigation → implementation

## Usage Instructions

### Getting Started with This Template

1. **Use This Documentation**: This file serves as your comprehensive project guide
2. **Update Regularly**: Keep sections current as your project evolves
3. **Team Knowledge**: Share patterns and decisions with your development team

### Integration with MCP Servers

- **Context7**: **MANDATORY** - Always use `/context7:read-docs` before coding, `/context7:retrieve-docs` to build comprehensive local documentation cache in `.claude/docs/`
- **Gemini CLI**: **Tier 2** - Use for large-scale code analysis and architectural feedback to save Claude Code tokens
- **Serena**: **Tier 3** - Leverage semantic search for precision targeting after Gemini discovery
- **Playwright**: Document any browser automation or testing workflows
- **Sequential-thinking**: Use for complex architectural decisions and structured problem-solving
- **Supabase**: Document database schemas and migration patterns
- **Brave Search**: Research ASP.NET Core best practices and current solutions

## 📚 Useful Resources

### ASP.NET Core Documentation
- **Microsoft Docs**: Official ASP.NET Core documentation and tutorials
- **.NET API Browser**: Comprehensive API reference documentation
- **Microsoft Learn**: Interactive learning modules and paths

### Community Resources
- **Stack Overflow**: Q&A for specific technical issues
- **Reddit r/dotnet**: Community discussions and news
- **ASP.NET Core GitHub**: Source code and issue tracking

### Database and Supabase Resources
- **Supabase Documentation**: Official guides and API reference
- **PostgreSQL Docs**: Database optimization and query tuning
- **Supabase Community**: Discord and GitHub discussions

---

**This is a living document.** Update and improve it as you discover new patterns and build out your project. Keep sections concise and focused on information Claude needs for effective development assistance.