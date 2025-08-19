# Context7 Retrieve Documentation

Retrieve fresh, up-to-date documentation using Context7 MCP server and store locally for cost-effective reuse. Always fetches the latest documentation regardless of local cache.

## Problem/Request: $ARGUMENTS

## Execution Process

1. **Read Storage Instructions**

   - Read `.claude/docs/CLAUDE.md` to understand the local storage workflow
   - Review the folder organization structure for documentation storage
   - Understand the cost optimization strategy

2. **Analyze User Request**

   - Parse the documentation request or development problem
   - Identify what libraries, frameworks, or topics need documentation
   - Determine the type of documentation needed (APIs, guides, examples)

3. **Use Context7 MCP Server**

   - Use the Context7 MCP server to fetch current, up-to-date documentation
   - Request specific sections relevant to the user's problem
   - Retrieve version-specific code examples and best practices
   - Get comprehensive documentation that addresses the user's needs

4. **Organize and Store Locally**

   - Create appropriate subdirectories in `.claude/docs/` following the structure:
     - `libraries/` for third-party library documentation
     - `apis/` for API documentation and schemas
     - `project/` for project-specific documentation
     - `guides/` for development guides and tutorials
   - Save retrieved documentation with meaningful filenames
   - Use markdown format for optimal Claude Code compatibility
   - Include metadata about when docs were retrieved and from what source

5. **Provide Usage Guidance**
   - Explain what documentation was stored and where
   - Show how to reference the cached documentation in future development
   - Highlight the cost savings from using local copies vs repeated Context7 calls
   - Provide next steps for using the documentation in the current development task

## Cost Optimization Benefits

- **Reduced token usage**: Avoid repeated API calls for same documentation
- **Faster access**: Local docs load immediately without network requests
- **Credit efficiency**: Lower costs by reusing cached documentation
- **Offline availability**: Documentation remains accessible without MCP server calls

## File Organization Example

```
.claude/docs/
├── libraries/
│   ├── fastapi-auth-2024-08-16.md
│   └── pydantic-v2-validation.md
├── apis/
│   ├── stripe-api-reference.md
│   └── openai-api-docs.md
├── project/
│   └── authentication-patterns.md
└── guides/
    └── testing-strategies.md
```

## Validation

- Confirm documentation was successfully retrieved from Context7
- Verify files are properly saved in correct directories
- Check that documentation is relevant to the user's request
- Ensure markdown formatting is preserved for readability
