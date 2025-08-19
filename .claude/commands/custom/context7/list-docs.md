# Context7 List Documentation

Display all cached documentation organized by library, with metadata and freshness indicators. Provides visibility into available local documentation for cost-effective development planning.

## Problem/Request: $ARGUMENTS

## Execution Process

1. **Scan Documentation Cache**
   - Recursively scan `.claude/docs/` directory structure
   - Identify all documentation files in subdirectories (libraries/, apis/, guides/, project/)
   - Parse filenames to extract library names, topics, and dates
   - Collect metadata from file headers when available

2. **Organize Documentation Inventory**
   - Group documentation by library/framework (React, Vue, Angular, etc.)
   - Sort by category (libraries, APIs, guides, project-specific)
   - Extract key information: file size, creation date, last modified
   - Parse documentation headers for trust scores and source information

3. **Assess Documentation Freshness**
   - Calculate age of each documentation file
   - Flag outdated documentation (>30 days old) for potential refresh
   - Identify comprehensive vs partial documentation coverage
   - Note which libraries have multiple topic files vs single comprehensive files

4. **Generate Organized Display**
   - Present documentation in clear, hierarchical format
   - Show library names with associated topics and files
   - Include metadata: dates, file sizes, trust scores, source
   - Highlight outdated documentation with refresh suggestions
   - Provide file path references for direct access

5. **Provide Enhancement Suggestions**
   - Suggest missing documentation that would be valuable to cache
   - Recommend `/context7-refresh-docs` for outdated files
   - Highlight libraries with partial coverage that could be expanded
   - Calculate and display total storage saved vs Context7 API calls

6. **Optional Filtering**
   - If $ARGUMENTS contains library name: Filter display to specific library
   - If $ARGUMENTS contains topic: Show documentation containing that topic
   - If $ARGUMENTS is empty: Show complete documentation inventory

## Display Format

```
## Documentation Cache Inventory

### Libraries (X libraries, Y files, Z MB total)

#### React (Trust: 10/10)
- react-useState-2024-08-16.md (45KB) - State management hooks
- react-useEffect-2024-08-15.md (38KB) - Side effects and lifecycle
⚠️ react-routing-2024-07-10.md (22KB) - OUTDATED (37 days old)

#### Vue (Trust: 9/10) 
- vue-composition-2024-08-14.md (52KB) - Composition API guide
📝 Suggestion: Add Vue 3 reactivity documentation

### APIs (X files)
- stripe-payments-2024-08-12.md (67KB) - Payment processing
- openai-api-2024-08-16.md (89KB) - AI/ML integration

### Guides (X files)
- testing-strategies-2024-08-10.md (43KB) - Unit and integration testing
- deployment-patterns-2024-08-09.md (56KB) - CI/CD workflows

## Storage Statistics
📊 Total cached: X MB
💰 Estimated Context7 calls saved: Y calls
⚡ Average lookup time: <1ms (vs 2-5s Context7 fetch)

## Recommendations
🔄 Run `/context7-refresh-docs react routing` to update outdated React routing docs
📚 Run `/context7-retrieval vue reactivity` to add Vue reactivity documentation
```

## Search and Filtering

**Library-Specific Display:**
```bash
/context7-list-docs react
→ Show only React-related documentation
```

**Topic-Based Search:**
```bash
/context7-list-docs hooks
→ Show all documentation mentioning hooks (React, Vue, etc.)
```

**Full Inventory:**
```bash
/context7-list-docs
→ Show complete documentation cache organized by category
```

## Metadata Extraction

**From Filenames:**
- **Library identification**: Extract library name from filename pattern
- **Topic extraction**: Identify specific topics (useState, routing, etc.)
- **Date parsing**: Extract retrieval dates from filename timestamps

**From File Headers:**
- **Trust scores**: Parse Context7 trust score metadata
- **Source information**: Identify original documentation source
- **Version information**: Extract library version when available
- **Topic coverage**: Parse topic lists from document metadata

## Freshness Assessment

**Age Categories:**
- **Fresh**: 0-7 days (🟢 Green indicator)
- **Recent**: 8-30 days (🟡 Yellow indicator)  
- **Outdated**: 31+ days (🔴 Red indicator with refresh suggestion)

**Coverage Assessment:**
- **Comprehensive**: Complete API reference with examples
- **Partial**: Limited topic coverage or basic information only
- **Fragment**: Small code snippets or incomplete documentation

## Enhancement Recommendations

**Automatic Suggestions:**
- Identify popular libraries missing from cache
- Suggest complementary documentation for existing libraries
- Recommend comprehensive docs for libraries with only partial coverage
- Flag outdated documentation for refresh

**Command Integration:**
- Link to `/context7-retrieval` for missing documentation
- Link to `/context7-refresh-docs` for outdated files
- Link to `/context7-read-docs` for accessing specific documentation

## Cost Analysis Display

**Storage Benefits:**
- Total local storage used
- Estimated Context7 API calls saved
- Average response time comparison (local vs network)
- Projected cost savings based on usage patterns

**Performance Metrics:**
- Number of successful local lookups vs Context7 fallbacks
- Average documentation age across all cached files
- Coverage percentage for major frameworks

## Validation

- Confirm all documentation files are found and categorized correctly
- Verify metadata extraction accuracy for dates, sizes, and trust scores
- Check that freshness indicators are correctly applied
- Ensure filtering and search functionality works as expected
- Validate that enhancement suggestions are relevant and actionable