# Testing Documentation

## Test Suite Overview

The `ntoskrnlib.Tests` project contains comprehensive tests for the Structure namespace, validating:
- DynamicStructure attribute functionality
- Offset attribute support (both reflection-based and zero-reflection)
- Reading and writing memory structures
- Nested structures and pointer dereferencing
- Memory pointer arithmetic and operations
- Array operations via DynamicArray

## Running Tests Locally

### Run all tests
```bash
dotnet test ntoskrnlib.Tests/ntoskrnlib.Tests.csproj
```

### Run specific test class
```bash
dotnet test --filter "FullyQualifiedName~StructureReadWriteTests"
```

### Run with detailed output
```bash
dotnet test --verbosity normal
```

### Run and generate coverage report
```bash
dotnet test --collect:"XPlat Code Coverage"
```

## Test Structure

### Test Files
- **DynamicStructureAttributeTests.cs** - Attribute validation tests
- **StructureReadWriteTests.cs** - Memory read/write operations
- **ZeroReflectionTests.cs** - Zero-reflection offset registration
- **NestedStructureTests.cs** - Nested structures and pointer chains
- **DynamicArrayTests.cs** - Array access and operations
- **MemoryPointerTests.cs** - Pointer arithmetic and comparisons
- **DynamicStructureTests.cs** - Comprehensive integration tests

### Test Infrastructure
- **TestMemorySource.cs** - In-memory IMemorySource implementation
- **TestStructures.cs** - Sample structures for testing
- **TestFixtureBase.cs** - Base class for test initialization

## GitHub Workflow Integration

Tests are automatically run in the CI/CD pipeline before building and publishing:

```
┌─────────────┐
│   version   │ - Compute version based on commits
└──────┬──────┘
       │
       ↓
┌─────────────┐
│    test     │ - Run all unit tests
└──────┬──────┘
       │
       ↓ (only if tests pass)
┌─────────────┐
│    build    │ - Build library and generate types
└──────┬──────┘
       │
       ↓ (only if build succeeds and content changed)
┌─────────────┐
│   publish   │ - Publish to NuGet and create tags
└─────────────┘
```

### Workflow Behavior

1. **Test Job** (runs first)
   - Restores dependencies
   - Builds test project
   - Runs all tests with detailed logging
   - Uploads test results as artifacts
   - Generates test report
   - **FAILS THE WORKFLOW IF TESTS FAIL**

2. **Build Job** (depends on test passing)
   - Only runs if test job succeeds
   - Builds main library
   - Generates Windows kernel types
   - Creates NuGet package

3. **Publish Job** (depends on build passing)
   - Only runs if build succeeds and content changed
   - Publishes to NuGet
   - Creates version tag

### Test Results in GitHub Actions

Test results are available in multiple formats:
- **Console output** - In the "Run tests" step
- **Test Report** - Visual report in the Actions UI
- **Artifacts** - Downloadable TRX files for detailed analysis

## Current Test Status

**70 out of 82 tests passing (85%)**

### Known Issues

1. **DynamicArray tests** (9 failures)
   - Root cause: `DynamicArray` class needs `[DynamicStructure]` attribute
   - Location: `ntoskrnlib.Common/Structure/DynamicArray.cs:8`

2. **Address range tests** (3 failures)
   - Root cause: Test addresses exceed 4096-byte memory buffer
   - Tests affected:
     - `DynamicStructure_CanReadNegativeIntegers` (address 0x1100)
     - `DynamicStructure_CanReadMaxValues` (address 0x1200)

3. **KeyBasedTestStruct** (excluded from automatic registration)
   - Requires `IOffsetParser` configuration
   - Not a blocker for other tests

## Fixing Remaining Issues

### Fix DynamicArray tests
Add the attribute to DynamicArray.cs:
```csharp
[DynamicStructure("DynamicArray")]  // Add this line
public class DynamicArray : DynamicStructure
{
    // ...
}
```

### Fix address range tests
Increase test memory size in DynamicStructureTests.cs:
```csharp
public DynamicStructureTests()
{
    _memory = new TestMemorySource(8192);  // Increase from 4096 to 8192
}
```

## Future Enhancements

- Add performance benchmarks
- Add integration tests with actual Windows kernel symbols
- Add mutation testing for better coverage
- Add code coverage reporting
