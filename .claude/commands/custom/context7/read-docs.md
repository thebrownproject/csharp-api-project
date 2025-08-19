# Context7 Read Documentation

Read documentation from local cache first, with optional Context7 fallback for missing or incomplete information. Prioritizes cost-effective local access while maintaining access to fresh documentation when needed.

## Problem/Request: $ARGUMENTS

## Execution Process

1. **Analyze Request**

   - Parse the documentation request to identify library, framework, or topic
   - Extract key terms and concepts for matching
   - Determine the type of information needed (API reference, examples, guides)

2. **Search Local Documentation Cache**

   - Scan `.claude/docs/` structure for relevant documentation
   - Use fuzzy matching for library names (e.g., "react" matches "react-useState-2024-08-16.md")
   - Search file contents for specific topics and keywords using grep
   - Score relevance of found documentation based on topic match and freshness

3. **Present Local Documentation**

   - Extract and present relevant sections from cached documentation
   - Show source information (library, retrieval date, trust score)
   - Highlight the most relevant parts based on the user's specific request
   - Organize content logically (API reference, examples, best practices)

4. **Assess Completeness**

   - Evaluate if local documentation fully addresses the user's request
   - Identify any gaps in coverage or missing information
   - Check if documentation is outdated (>30 days old)
   - Determine if additional Context7 retrieval would be beneficial

5. **Optional Context7 Fallback**

   - If gaps identified: Clearly describe what information is missing
   - Suggest using `/context7-retrieval [specific library/topic]` to fetch missing documentation
   - Reference the context7-retrieval.md command for fresh documentation retrieval
   - Provide specific command example: "Run `/context7-retrieval vue composition api` to get Vue docs"
   - If no gaps: Provide guidance based on complete local documentation

6. **Provide Comprehensive Response**
   - Present available local documentation with clear organization
   - Reference specific file locations for future access
   - Suggest related local documentation that might be helpful
   - Highlight cost savings from using cached documentation
   - Include clear next steps if additional documentation is needed

## Local Search Strategy

**File Matching:**

- **Direct filename matching**: "react" → find files starting with "react-"
- **Topic matching**: "hooks" → search for "hooks", "useState", "useEffect" in content
- **Fuzzy matching**: "nextjs" → match "next-js", "nextjs", "next.js" variations

**Content Search:**

- **Keyword extraction**: Parse user request for technical terms
- **Section targeting**: Look for specific API methods, components, patterns
- **Example prioritization**: Highlight code examples relevant to user's use case

**Relevance Scoring:**

- **Exact library match**: Higher priority for direct library matches
- **Topic relevance**: Score based on keyword density and context
- **Freshness factor**: Recent documentation scores higher
- **Completeness**: Comprehensive docs score higher than fragments

## Smart Fallback Logic

**When to Suggest `/context7-retrieval`:**

- No local documentation found for requested library/topic
- Local documentation is outdated (>30 days old)
- User request is very specific and not covered in local docs
- Local documentation exists but lacks depth for complex topics

**When to Use Local Only:**

- Comprehensive local documentation exists and is recent
- User request is fully covered by cached documentation
- Basic API reference or examples are sufficient
- User explicitly wants to avoid additional API calls

## Cost Optimization Benefits

- **Primary benefit**: Use free local file access instead of Context7 API calls
- **Fast responses**: Instant access to cached documentation without network delay
- **Selective enhancement**: Only fetch additional docs when truly needed via `/context7-retrieval`
- **Building knowledge**: Each Context7 retrieval adds to local library for future use
- **User control**: User chooses whether to run `/context7-retrieval` for additional information

## Example Usage Scenarios

**Scenario 1: Full Local Coverage**

```
User: "Show me React useState examples"
→ Found: react-useState-2024-08-16.md (comprehensive, recent)
→ Result: Present complete local documentation, no additional retrieval needed
```

**Scenario 2: Partial Local Coverage**

```
User: "Help with advanced React performance optimization"
→ Found: react-useState-2024-08-16.md (basic info only)
→ Result: Present basic info, suggest `/context7-retrieval react performance optimization`
```

**Scenario 3: No Local Coverage**

```
User: "Vue 3 Composition API documentation"
→ Found: No Vue documentation in local cache
→ Result: Suggest `/context7-retrieval vue composition api` to fetch Vue docs
```

## Command Integration

- **For missing docs**: Direct users to `/context7-retrieval [library/topic]`
- **For comprehensive search**: Use `/context7-list-docs` to see all available documentation
- **For updates**: Suggest `/context7-refresh-docs [library]` for outdated documentation

## Validation

- Confirm relevant local documentation was found and presented
- Verify that documentation addresses the user's specific request
- Check that `/context7-retrieval` suggestions are specific and actionable
- Ensure user has clear guidance for next steps
- Validate that cost optimization benefits are achieved
