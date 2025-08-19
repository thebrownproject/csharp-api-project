# Context7 Refresh Documentation

Update specific cached documentation by retrieving fresh versions from Context7. Maintains local documentation currency while preserving cost optimization benefits through selective updates.

## Problem/Request: $ARGUMENTS

## Execution Process

1. **Parse Refresh Target**
   - Identify specific library, framework, or topic to refresh from $ARGUMENTS
   - If no specific target provided: Use `/context7-list-docs` to show outdated documentation
   - Parse target into library name and optional specific topics
   - Determine scope: single file vs entire library documentation

2. **Locate Existing Documentation**
   - Search `.claude/docs/` for files matching the target library/topic
   - Identify all related documentation files for comprehensive refresh
   - Check current file dates and sizes for comparison baseline
   - Read existing metadata (trust scores, source information, version)

3. **Pre-Refresh Assessment**
   - Display current documentation found for the target
   - Show age of existing documentation and reasons for refresh
   - Calculate current storage and estimated Context7 costs for refresh
   - Confirm refresh scope with user if multiple files are involved

4. **Execute Context7 Retrieval**
   - Use `/context7-retrieval` workflow to fetch fresh documentation
   - Target the same library/topic with enhanced specificity if needed
   - Retrieve comprehensive, up-to-date documentation from Context7
   - Ensure all related topics are covered in the refresh

5. **Compare and Update**
   - Compare new documentation with existing cached version
   - Highlight significant changes, additions, or updates
   - Replace outdated files with fresh documentation
   - Preserve file organization and naming conventions
   - Update metadata with new retrieval date and source information

6. **Post-Refresh Report**
   - Show what documentation was updated and key changes
   - Display new vs old file sizes and dates
   - Highlight new features, API changes, or additional examples
   - Provide summary of refresh benefits and updated coverage
   - Reference file locations for immediate access

## Refresh Strategies

**Single Library Refresh:**
```bash
/context7-refresh-docs react
→ Update all React-related documentation
```

**Topic-Specific Refresh:**
```bash  
/context7-refresh-docs react hooks
→ Update only React hooks documentation
```

**Comprehensive Refresh:**
```bash
/context7-refresh-docs
→ Show outdated docs and provide refresh options
```

## Smart Refresh Logic

**Automatic Refresh Candidates:**
- Documentation older than 30 days
- Libraries with known recent major updates
- Incomplete documentation that could benefit from comprehensive refresh
- Documentation with lower trust scores that might have improved

**Selective Refresh Benefits:**
- Update only what's needed to minimize Context7 costs
- Preserve recent, comprehensive documentation
- Focus on libraries actively being used in current development
- Maintain local documentation quality without unnecessary API calls

## Change Detection and Reporting

**Content Comparison:**
- **New sections**: Identify newly added API methods, components, or guides
- **Updated examples**: Highlight improved or additional code examples  
- **Deprecated features**: Note removed or deprecated functionality
- **Version changes**: Track library version updates and breaking changes

**Metadata Updates:**
- **Trust scores**: Show improved trust scores for refreshed documentation
- **Source changes**: Note if documentation source has changed or improved
- **Coverage expansion**: Highlight additional topics now covered
- **File size changes**: Indicate comprehensive vs minor updates

## Batch Refresh Operations

**Multiple Library Updates:**
```bash
/context7-refresh-docs react vue angular
→ Refresh documentation for multiple libraries
```

**Outdated Documentation Sweep:**
```bash
/context7-refresh-docs --outdated
→ Refresh all documentation older than 30 days
```

**Framework-Specific Updates:**
```bash
/context7-refresh-docs --framework
→ Refresh all frontend framework documentation
```

## Integration with Other Commands

**Discovery Integration:**
- Use `/context7-list-docs` to identify refresh candidates
- Reference outdated documentation flags from list command
- Provide targeted refresh suggestions based on current cache state

**Retrieval Integration:**
- Leverage `/context7-retrieval` command workflow for actual fetching
- Maintain consistent storage and organization patterns
- Preserve all retrieval benefits (metadata, formatting, validation)

**Read Integration:**
- Update `/context7-read-docs` cache immediately after refresh
- Ensure refreshed documentation is immediately available for local reading
- Maintain relevance scoring with updated content and dates

## Cost-Benefit Analysis

**Refresh Justification:**
- **High usage documentation**: Prioritize frequently accessed libraries
- **Outdated critical information**: Refresh documentation for active projects
- **Incomplete coverage**: Enhance partial documentation with comprehensive updates
- **Version mismatches**: Update documentation to match current library versions

**Cost Optimization:**
- **Selective refresh**: Update only what's needed, not everything
- **Bulk operations**: Refresh related documentation in single Context7 session
- **Usage tracking**: Prioritize refresh based on actual documentation usage
- **Strategic timing**: Refresh before major development phases

## Validation and Quality Assurance

**Pre-Refresh Validation:**
- Confirm target documentation exists and is outdated
- Verify Context7 connectivity and library availability
- Check storage space and organization structure

**Post-Refresh Validation:**
- Confirm successful retrieval and storage of updated documentation
- Verify metadata accuracy and file organization
- Check that refreshed documentation addresses original gaps or outdated information
- Ensure backward compatibility with existing development workflows

**Quality Metrics:**
- Compare comprehensiveness of old vs new documentation
- Verify trust score improvements and source reliability
- Check that all related topics are covered in refresh
- Ensure examples and code snippets are current and functional

## Example Refresh Scenarios

**Scenario 1: Routine Library Update**
```
User: "/context7-refresh-docs react"
→ Found: react-useState-2024-07-15.md (32 days old)
→ Action: Refresh all React documentation
→ Result: Updated react-useState-2024-08-16.md with latest hooks patterns
```

**Scenario 2: Targeted Topic Refresh**
```
User: "/context7-refresh-docs next.js routing"
→ Found: nextjs-routing-2024-07-20.md (outdated)
→ Action: Refresh Next.js routing documentation specifically
→ Result: Updated with App Router and server components
```

**Scenario 3: Comprehensive Framework Refresh**
```
User: "/context7-refresh-docs --outdated"
→ Found: 5 outdated libraries (React, Vue, Angular, Svelte, Next.js)
→ Action: Batch refresh all outdated framework documentation
→ Result: Complete framework documentation refresh with change summary
```