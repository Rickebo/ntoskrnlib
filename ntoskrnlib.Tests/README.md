# ntoskrnlib.Tests

Comprehensive test suite for the `ntoskrnlib.Structure` namespace, validating DynamicStructure functionality.

## Overview

This test project validates that classes using the `DynamicStructure` attribute and `Offset` attributes can be correctly read from memory using both reflection-based and zero-reflection registration patterns.

## Test Coverage

### 1. DynamicStructure Attribute Tests
- ✅ Validates that test structures have the `[DynamicStructure]` attribute
- ✅ Verifies the `BackingSymbolName` property is correctly set
- ✅ Tests for missing attribute on invalid structures

### 2. Offset Attribute Tests (Reflection-Based)
- ✅ Validates that properties have the `[Offset]` attribute
- ✅ Verifies offset values are correctly specified
- ✅ Tests reading single fields using offsets
- ✅ Tests reading multiple fields from the same structure

### 3. Zero-Reflection Registration Tests
- ✅ Validates that zero-reflection structures don't use `[Offset]` attributes
- ✅ Tests explicit offset dictionary registration
- ✅ Verifies fields can be read using explicitly registered offsets

### 4. Nested Structures and Pointer Dereferencing
- ✅ Tests reading nested DynamicStructure instances
- ✅ Validates pointer dereferencing through nested structures
- ✅ Tests multi-level pointer chains (multiple dereferences)

### 5. MemoryPointer Operations
- ✅ Arithmetic operations (+, -, ++, --)
- ✅ Pointer difference calculations
- ✅ Validation checks (IsValid())
- ✅ Comparison operators (<, >, <=, >=, ==, !=)
- ✅ Equality and CompareTo implementations

### 6. DynamicArray Tests
- ✅ Reading single array elements
- ✅ Reading multiple array elements
- ✅ Reading array ranges
- ✅ Testing with different data types (int, byte, long, ulong)
- ✅ Reading struct arrays
- ✅ Index calculation validation

### 7. Write Operations
- ✅ Writing values to memory
- ✅ Reading back written values
- ✅ Verifying memory updates

### 8. Edge Cases
- ✅ Reading from zero offset
- ✅ Negative integers
- ✅ Maximum values (int.MaxValue, long.MaxValue, uint.MaxValue)

## Test Structures

### SimpleStruct
Reflection-based registration with `[Offset]` attributes.
```csharp
[DynamicStructure("test!SimpleStruct")]
public sealed class SimpleStruct : DynamicStructure
{
    [Offset(0x0UL)] public int Value { get; }
    [Offset(0x4UL)] public long Number { get; }
    [Offset(0xCUL)] public uint Flags { get; }
}
```

### ZeroReflectionStruct
Zero-reflection registration with explicit offset dictionary.
```csharp
[DynamicStructure("test!ZeroReflectionStruct")]
public sealed class ZeroReflectionStruct : DynamicStructure
{
    public byte Status { get; }
    public int Count { get; }
    public ulong Pointer { get; }

    static ZeroReflectionStruct()
    {
        var offsets = new Dictionary<string, ulong[]>
        {
            { nameof(Status), new[] { 0x0UL } },
            { nameof(Count), new[] { 0x4UL } },
            { nameof(Pointer), new[] { 0x8UL } }
        };
        Register<ZeroReflectionStruct>((mem, ptr) => new ZeroReflectionStruct(mem, ptr), offsets);
    }
}
```

### ParentStruct
Demonstrates nested structure reading.
```csharp
[DynamicStructure("test!ParentStruct")]
public sealed class ParentStruct : DynamicStructure
{
    [Offset(0x0UL)] public int Id { get; }
    [Offset(0x8UL)] public ulong NestedPtr { get; }

    public SimpleStruct GetNested() => ReadStructure<SimpleStruct>(new[] { 0x8UL });
}
```

### PointerChainStruct
Tests multi-level pointer dereferencing.
```csharp
[DynamicStructure("test!PointerChainStruct")]
public sealed class PointerChainStruct : DynamicStructure
{
    [Offset(0x0UL)] public ulong FirstPtr { get; }

    public int GetValueFromChain() => Read<int>(new[] { 0x0UL, 0x0UL });
}
```

## TestMemorySource

A simple in-memory implementation of `IMemorySource` for testing:
- Allocates a byte array for simulated memory
- Supports reading/writing primitive types
- Bounds checking for all operations
- Helper methods for byte array operations

## Running the Tests

```bash
# Build the test project
dotnet build ntoskrnlib.Tests/ntoskrnlib.Tests.csproj

# Run all tests
dotnet test ntoskrnlib.Tests/ntoskrnlib.Tests.csproj

# Run with detailed output
dotnet test ntoskrnlib.Tests/ntoskrnlib.Tests.csproj --logger "console;verbosity=detailed"

# Run specific test class
dotnet test --filter "FullyQualifiedName~DynamicStructureTests"

# Run specific test
dotnet test --filter "FullyQualifiedName~DynamicStructureTests.SimpleStruct_CanReadValueUsingOffset"
```

## Test Files

- `DynamicStructureTests.cs` - Main test suite for DynamicStructure functionality
- `DynamicArrayTests.cs` - Tests for DynamicArray helper class
- `TestStructures.cs` - Test structure definitions
- `TestMemorySource.cs` - In-memory IMemorySource implementation

## Key Validation Points

1. **Attribute Validation**: Ensures structures are properly annotated
2. **Memory Layout**: Verifies correct offset calculations
3. **Type Safety**: Tests reading various data types
4. **Pointer Semantics**: Validates pointer arithmetic and dereferencing
5. **Registration Patterns**: Tests both reflection and zero-reflection approaches
6. **Array Operations**: Validates contiguous memory access patterns

## Dependencies

- xUnit 2.9.0
- xunit.runner.visualstudio 2.8.2
- Microsoft.NET.Test.Sdk 17.11.0
- coverlet.collector 6.0.2
- ntoskrnlib.Common (project reference)
