# CLAUDE.md - Universal Project Template

This file provides comprehensive guidance to Claude Code when working with any project based on the Claude Code Master Template. It contains essential template context and buildable sections that grow with your project.

## Template Foundation

### 🎯 **What This Template Provides**

- **Integrated AI Development Methodologies**: Ready for BMAD Method and modern AI-assisted development
- **MCP Server Integration**: 7 pre-configured servers for enhanced development capabilities
- **Context7 Documentation Management**: Intelligent local-first documentation caching and retrieval
- **Three-Tier Token Optimization**: Strategic escalation from built-ins → Gemini CLI → Serena for maximum efficiency
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

- `libraries/` - Third-party library docs (e.g., `react-hooks-2024-08-16.md`)
- `apis/` - API documentation and schemas (e.g., `stripe-payments-2024-08-12.md`)
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

<!-- TODO: Add project description, goals, and key features
Examples:
- What problem does this project solve?
- Who are the target users?
- What are the main features and capabilities?
- What makes this project unique?
-->

## 🛠️ Technology Stack

<!-- TODO: Document chosen technologies and tools
- Language and version
- Framework and database
- Key dependencies
-->

## 📁 Project Structure

<!-- TODO: Document key directories and file organization
```
project-root/
├── src/                    # Source code
│   ├── components/         # Reusable UI components
│   ├── pages/             # Page components/routes
│   ├── lib/               # Core business logic
│   ├── utils/             # Helper functions
│   └── types/             # Type definitions
├── tests/                 # Test files
├── docs/                  # Project documentation
├── config/                # Configuration files
└── scripts/               # Build/deployment scripts
```

Key principles:
- Feature-based vs technical organization
- Where to place new files
- Naming conventions for directories
-->

## 🏗️ Architecture

<!-- TODO: Document system architecture, major components, and data flow
Examples:
- High-level system diagram
- Major components and their responsibilities
- Data flow between components
- External integrations and APIs
- Database schema overview
-->

## 📋 Development Environment & Configuration

<!-- TODO: Add setup instructions, environment variables, and configuration management
- Prerequisites and installation steps
- Environment variables and local development setup
- Database setup and migrations
- Configuration management (environment-specific settings, feature flags)
-->

## 🔧 Language-Specific Tooling

<!-- TODO: Document development tools and package management
- Package management and virtual environments
- Code formatting and linting tools
- Testing framework and build system
-->

## 🧪 Testing Strategy

<!-- TODO: Document testing approach and coverage goals
- Unit, integration, and e2e testing frameworks
- Test organization and data management
- Coverage requirements and CI/CD integration
-->

## 📚 API Documentation

<!-- TODO: Document API endpoints and schemas
- API endpoints and request/response formats
- Authentication and rate limiting
- Error codes and documentation links
-->

## 🚀 Deployment

<!-- TODO: Document deployment process and CI/CD
- Deployment environments and pipeline configuration
- Infrastructure requirements and environment variables
- Monitoring, health checks, and rollback procedures
-->

## 📖 Project-Specific Guidelines

<!-- TODO: Add project-specific coding standards and conventions
- Code style, naming conventions, and file organization
- Code review requirements and documentation standards
- Project-specific performance or compliance requirements
-->

## 🔗 Dependencies

<!-- TODO: Document key dependencies and their purposes
- Core framework and database libraries
- Authentication, security, and utility libraries
- Development and testing dependencies with rationale
-->

## 🛠️ Development Tools & Commands

<!-- TODO: Document development commands, debugging tools, and utilities
- Start/Build/Test Commands: npm run dev/build/test, cargo run/build/test
- Code Quality: linting, formatting, type checking commands
- Database Operations: migration, seed, backup commands
- Debugging Tools: interactive debuggers, profilers, browser devtools
- API Testing: Postman, curl, testing frameworks
-->

## Usage Instructions

### Getting Started with This Template

1. **Copy Template**: When starting a new project, copy this file to your project root as `CLAUDE.md`
2. **Fill Placeholders**: Work through the TODO sections, building out project-specific information
3. **Layer Language Config**: Optionally combine with language-specific configs from this folder
4. **Iterate**: Update sections as your project evolves and new patterns emerge

### When to Update Sections

- **Project Overview**: During initial planning and when scope changes
- **Technology Stack**: When adding/removing major dependencies
- **Architecture**: When system design evolves or new components are added
- **Development Environment**: When setup procedures change
- **Testing Strategy**: When adopting new testing approaches
- **API Documentation**: When endpoints change or new APIs are added
- **All Other Sections**: As relevant information becomes available

### Building Out Documentation

- **Start Small**: Begin with brief bullet points, expand over time
- **Be Specific**: Include actual commands, file paths, and examples
- **Keep Current**: Review and update regularly as project evolves
- **Team Knowledge**: Capture decisions and patterns for future developers

### Three-Tier Token Optimization Strategy

**MANDATORY: Follow this escalation strategy for maximum token efficiency**

#### **Tier 1: Claude Code Built-ins** (Start Here)
- **Tools**: `Grep`, `Glob`, `Read`, `LS`
- **Use for**: Small projects, known file locations, simple pattern searches
- **Cost**: Free/minimal token usage

#### **Tier 2: Gemini CLI** (Scale Up for Large Analysis)
- **Massive Context**: 1M+ token window for bulk analysis
- **Use for**: Large codebase exploration, architectural understanding, "analyze entire codebase" queries
- **Strategy**: Leverage Gemini's generous context limits to save Claude Code tokens
- **Perfect for**: Planning phases, comprehensive code reviews, alternative perspectives

#### **Tier 3: Serena MCP** (Precision Targeting)
- **Use for**: Precise symbol-level navigation when Gemini identifies specific targets
- **Tools**: `search_for_pattern`, `get_symbols_overview`, `find_symbol`, `write_memory`
- **Strategy**: Semantic analysis without full file reads after Gemini bulk discovery

#### **Decision Matrix**
- **Small/Medium projects**: Tier 1 → Direct Claude Code editing
- **Large codebases**: Tier 2 (Gemini bulk) → Tier 3 (Serena precision) → Claude Code editing
- **Unknown structure**: Tier 2 exploration → Tier 3 navigation → implementation

### Integration with MCP Servers

- **Context7**: **MANDATORY** - Always use `/context7:read-docs` before coding, `/context7:retrieve-docs` to build comprehensive local documentation cache in `.claude/docs/`
- **Gemini CLI**: **Tier 2** - Use for large-scale code analysis and architectural feedback to save Claude Code tokens
- **Serena**: **Tier 3** - Leverage semantic search for precision targeting after Gemini discovery
- **Playwright**: Document any browser automation or testing workflows
- **Sequential-thinking**: Use for complex architectural decisions and structured problem-solving
- **Supabase**: Document database schemas and migration patterns
- **Brave Search**: Research best practices and current solutions

## 📚 Useful Resources

<!-- TODO: Document key resources and documentation
- Language and framework documentation
- Best practice guides and community resources
- Tool documentation and learning materials
-->

---

**This is a living document.** Update and improve it as you discover new patterns and build out your project. The placeholder sections should evolve into comprehensive project documentation that serves both development and future maintenance.
