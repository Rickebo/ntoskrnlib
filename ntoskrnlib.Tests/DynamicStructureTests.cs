using ntoskrnlib.Structure;
using Xunit;

namespace ntoskrnlib.Tests;

/// <summary>
/// Comprehensive tests for DynamicStructure functionality, including:
/// - DynamicStructure attribute validation
/// - Offset attribute validation (reflection-based)
/// - Zero-reflection offset registration
/// - Nested structures and pointer dereferencing
/// - Memory pointer operations
/// </summary>
public class DynamicStructureTests : TestFixtureBase
{
    private readonly TestMemorySource _memory;

    public DynamicStructureTests()
    {
        _memory = new TestMemorySource(8192);  // Increased from 4096 to accommodate all test addresses
    }

    #region DynamicStructure Attribute Tests

    [Fact]
    public void SimpleTestStruct_HasDynamicStructureAttribute()
    {
        // Arrange & Act
        var attr = (DynamicStructureAttribute?)Attribute.GetCustomAttribute(
            typeof(SimpleTestStruct),
            typeof(DynamicStructureAttribute));

        // Assert
        Assert.NotNull(attr);
        Assert.Equal("test!SIMPLE_STRUCT", attr.BackingSymbolName);
    }

    [Fact]
    public void ZeroReflectionTestStruct_HasDynamicStructureAttribute()
    {
        // Arrange & Act
        var attr = (DynamicStructureAttribute?)Attribute.GetCustomAttribute(
            typeof(ZeroReflectionTestStruct),
            typeof(DynamicStructureAttribute));

        // Assert
        Assert.NotNull(attr);
        Assert.Equal("test!ZERO_REFLECTION_STRUCT", attr.BackingSymbolName);
    }

    [Fact]
    public void InvalidTestStruct_MissingDynamicStructureAttribute()
    {
        // Arrange & Act
        var attr = (DynamicStructureAttribute?)Attribute.GetCustomAttribute(
            typeof(InvalidTestStruct),
            typeof(DynamicStructureAttribute));

        // Assert
        Assert.Null(attr);
    }

    #endregion

    #region Offset Attribute Tests (Reflection-Based)

    [Fact]
    public void SimpleTestStruct_IntValueProperty_HasOffsetAttribute()
    {
        // Arrange
        var property = typeof(SimpleTestStruct).GetProperty(nameof(SimpleTestStruct.IntValue));

        // Act
        var attr = (Offset?)Attribute.GetCustomAttribute(property!, typeof(Offset));

        // Assert
        Assert.NotNull(attr);
        Assert.NotNull(attr.Offsets);
        Assert.Single(attr.Offsets);
        Assert.Equal(0x0UL, attr.Offsets[0]);
    }

    [Fact]
    public void SimpleTestStruct_LongValueProperty_HasOffsetAttribute()
    {
        // Arrange
        var property = typeof(SimpleTestStruct).GetProperty(nameof(SimpleTestStruct.LongValue));

        // Act
        var attr = (Offset?)Attribute.GetCustomAttribute(property!, typeof(Offset));

        // Assert
        Assert.NotNull(attr);
        Assert.NotNull(attr.Offsets);
        Assert.Single(attr.Offsets);
        Assert.Equal(0x8UL, attr.Offsets[0]);
    }

    [Fact]
    public void SimpleTestStruct_ByteValueProperty_HasOffsetAttribute()
    {
        // Arrange
        var property = typeof(SimpleTestStruct).GetProperty(nameof(SimpleTestStruct.ByteValue));

        // Act
        var attr = (Offset?)Attribute.GetCustomAttribute(property!, typeof(Offset));

        // Assert
        Assert.NotNull(attr);
        Assert.NotNull(attr.Offsets);
        Assert.Single(attr.Offsets);
        Assert.Equal(0x18UL, attr.Offsets[0]);
    }

    [Fact]
    public void SimpleTestStruct_CanReadValueUsingOffset()
    {
        // Arrange
        var baseAddr = (MemoryPointer)0x100UL;
        _memory.Write(baseAddr, 42);

        var service = new DynamicStructureService(_memory);

        // Act
        var structure = service.Read<SimpleTestStruct>(baseAddr);
        var value = structure.GetIntValue();

        // Assert
        Assert.Equal(42, value);
    }

    [Fact]
    public void SimpleTestStruct_CanReadMultipleFieldsUsingOffsets()
    {
        // Arrange
        var baseAddr = (MemoryPointer)0x100UL;
        _memory.Write(baseAddr, 1234);                     // IntValue at 0x100
        _memory.Write(baseAddr + 0x4, 5678U);              // UIntValue at 0x104
        _memory.Write(baseAddr + 0x8, 9876543210L);        // LongValue at 0x108
        _memory.Write(baseAddr + 0x10, 0xDEADBEEFCAFEUL);  // PointerValue at 0x110
        _memory.Write(baseAddr + 0x18, (byte)99);          // ByteValue at 0x118
        _memory.Write(baseAddr + 0x19, (short)777);        // ShortValue at 0x119

        var service = new DynamicStructureService(_memory);

        // Act
        var structure = service.Read<SimpleTestStruct>(baseAddr);

        // Assert
        Assert.Equal(1234, structure.GetIntValue());
        Assert.Equal(5678U, structure.GetUIntValue());
        Assert.Equal(9876543210L, structure.GetLongValue());
        Assert.Equal(0xDEADBEEFCAFEUL, structure.GetPointerValue());
        Assert.Equal(99, structure.GetByteValue());
        Assert.Equal(777, structure.GetShortValue());
    }

    #endregion

    #region Zero-Reflection Tests

    [Fact]
    public void ZeroReflectionTestStruct_PropertiesDoNotHaveOffsetAttributes()
    {
        // Arrange
        var value1Prop = typeof(ZeroReflectionTestStruct).GetProperty(nameof(ZeroReflectionTestStruct.Value1));
        var value2Prop = typeof(ZeroReflectionTestStruct).GetProperty(nameof(ZeroReflectionTestStruct.Value2));
        var value3Prop = typeof(ZeroReflectionTestStruct).GetProperty(nameof(ZeroReflectionTestStruct.Value3));

        // Act
        var value1Attr = (Offset?)Attribute.GetCustomAttribute(value1Prop!, typeof(Offset));
        var value2Attr = (Offset?)Attribute.GetCustomAttribute(value2Prop!, typeof(Offset));
        var value3Attr = (Offset?)Attribute.GetCustomAttribute(value3Prop!, typeof(Offset));

        // Assert - zero-reflection doesn't use [Offset] attributes
        Assert.Null(value1Attr);
        Assert.Null(value2Attr);
        Assert.Null(value3Attr);
    }

    [Fact]
    public void ZeroReflectionTestStruct_CanReadFieldsWithExplicitOffsets()
    {
        // Arrange
        var baseAddr = (MemoryPointer)0x200UL;
        _memory.Write(baseAddr, 42);                       // Value1 at 0x200
        _memory.Write(baseAddr + 0x8, 1234567890L);        // Value2 at 0x208
        _memory.Write(baseAddr + 0x10, 0xDEADBEEFU);       // Value3 at 0x210

        var service = new DynamicStructureService(_memory);

        // Act
        var structure = service.Read<ZeroReflectionTestStruct>(baseAddr);

        // Assert
        Assert.Equal(42, structure.GetValue1());
        Assert.Equal(1234567890L, structure.GetValue2());
        Assert.Equal(0xDEADBEEFU, structure.GetValue3());
    }

    #endregion

    #region Nested Structures Tests

    [Fact]
    public void NestedTestStruct_CanReadNestedStructure()
    {
        // Arrange
        var parentAddr = (MemoryPointer)0x300UL;
        var childAddr = (MemoryPointer)0x400UL;

        // Write parent structure
        _memory.Write(parentAddr, 123);                    // Id at 0x300
        _memory.Write(parentAddr + 0x8, childAddr.Value);  // ChildPointer at 0x308

        // Write child structure (SimpleTestStruct)
        _memory.Write(childAddr, 456);                     // IntValue at 0x400
        _memory.Write(childAddr + 0x4, 789U);              // UIntValue at 0x404
        _memory.Write(childAddr + 0x8, 9999L);             // LongValue at 0x408

        var service = new DynamicStructureService(_memory);

        // Act
        var parent = service.Read<NestedTestStruct>(parentAddr);
        var child = parent.GetChild();

        // Assert
        Assert.Equal(123, parent.GetId());
        Assert.Equal(childAddr.Value, parent.GetChildPointer());
        Assert.Equal(456, child.GetIntValue());
        Assert.Equal(789U, child.GetUIntValue());
        Assert.Equal(9999L, child.GetLongValue());
    }

    #endregion

    #region Pointer Dereferencing Tests

    [Fact]
    public void MultiLevelTestStruct_CanFollowPointerChain()
    {
        // Arrange
        var structAddr = (MemoryPointer)0x500UL;
        var firstPtrTarget = (MemoryPointer)0x600UL;
        var finalValue = 12345;

        // Build pointer chain: structAddr -> firstPtrTarget -> finalValue at offset 0x10
        _memory.Write(structAddr, firstPtrTarget.Value);       // Pointer at 0x500
        _memory.Write(firstPtrTarget + 0x10, finalValue);      // Final value at 0x610

        var service = new DynamicStructureService(_memory);

        // Act
        var structure = service.Read<MultiLevelTestStruct>(structAddr);
        var value = structure.GetDereferencedValue();

        // Assert
        Assert.Equal(12345, value);
    }

    #endregion

    #region MemoryPointer Tests

    [Fact]
    public void MemoryPointer_Addition_Works()
    {
        // Arrange
        var ptr = (MemoryPointer)0x100UL;

        // Act
        var result = ptr + 0x10;

        // Assert
        Assert.Equal(0x110UL, result.Value);
    }

    [Fact]
    public void MemoryPointer_Subtraction_Works()
    {
        // Arrange
        var ptr = (MemoryPointer)0x110UL;

        // Act
        var result = ptr - 0x10;

        // Assert
        Assert.Equal(0x100UL, result.Value);
    }

    [Fact]
    public void MemoryPointer_Difference_Works()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x110UL;
        var ptr2 = (MemoryPointer)0x100UL;

        // Act
        var difference = ptr1 - ptr2;

        // Assert
        Assert.Equal(0x10L, difference);
    }

    [Fact]
    public void MemoryPointer_Increment_Works()
    {
        // Arrange
        var ptr = (MemoryPointer)0x100UL;

        // Act
        ptr++;

        // Assert
        Assert.Equal(0x101UL, ptr.Value);
    }

    [Fact]
    public void MemoryPointer_Decrement_Works()
    {
        // Arrange
        var ptr = (MemoryPointer)0x100UL;

        // Act
        ptr--;

        // Assert
        Assert.Equal(0xFFUL, ptr.Value);
    }

    [Fact]
    public void MemoryPointer_IsValid_ReturnsTrueForValidAddress()
    {
        // Arrange
        var ptr = (MemoryPointer)0x100UL;

        // Act & Assert
        Assert.True(ptr.IsValid());
    }

    [Fact]
    public void MemoryPointer_IsValid_ReturnsFalseForZero()
    {
        // Arrange
        var ptr = (MemoryPointer)0UL;

        // Act & Assert
        Assert.False(ptr.IsValid());
    }

    [Fact]
    public void MemoryPointer_IsValid_ReturnsFalseForMaxValue()
    {
        // Arrange
        var ptr = (MemoryPointer)ulong.MaxValue;

        // Act & Assert
        Assert.False(ptr.IsValid());
    }

    [Fact]
    public void MemoryPointer_Comparison_Works()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x100UL;
        var ptr2 = (MemoryPointer)0x200UL;

        // Act & Assert
        Assert.True(ptr1 < ptr2);
        Assert.True(ptr2 > ptr1);
        Assert.True(ptr1 <= ptr2);
        Assert.True(ptr2 >= ptr1);
        Assert.True(ptr1 != ptr2);
        Assert.False(ptr1 == ptr2);
    }

    [Fact]
    public void MemoryPointer_Equality_Works()
    {
        // Arrange
        var ptr1 = (MemoryPointer)0x100UL;
        var ptr2 = (MemoryPointer)0x100UL;

        // Act & Assert
        Assert.True(ptr1 == ptr2);
        Assert.False(ptr1 != ptr2);
        Assert.Equal(ptr1, ptr2);
    }

    #endregion

    #region Write Operations Tests

    [Fact]
    public void SimpleTestStruct_CanWriteAndReadBack()
    {
        // Arrange
        var baseAddr = (MemoryPointer)0x800UL;
        _memory.Write(baseAddr, 100);
        _memory.Write(baseAddr + 0x8, 200L);

        var service = new DynamicStructureService(_memory);
        var structure = service.Read<SimpleTestStruct>(baseAddr);

        // Act - Verify initial values
        Assert.Equal(100, structure.GetIntValue());
        Assert.Equal(200L, structure.GetLongValue());

        // Modify the values using the structure's Write methods
        structure.SetIntValue(999);
        structure.SetLongValue(888L);

        // Act - Read again
        var updatedStructure = service.Read<SimpleTestStruct>(baseAddr);

        // Assert
        Assert.Equal(999, updatedStructure.GetIntValue());
        Assert.Equal(888L, updatedStructure.GetLongValue());
    }

    #endregion

    #region Edge Cases

    [Fact]
    public void DynamicStructure_CanReadFromZeroOffset()
    {
        // Arrange
        var baseAddr = (MemoryPointer)0x1000UL;
        _memory.Write(baseAddr, 12345);

        var service = new DynamicStructureService(_memory);

        // Act
        var structure = service.Read<SimpleTestStruct>(baseAddr);
        var value = structure.GetIntValue();

        // Assert
        Assert.Equal(12345, value);
    }

    [Fact]
    public void DynamicStructure_CanReadNegativeIntegers()
    {
        // Arrange
        var baseAddr = (MemoryPointer)0x1100UL;
        _memory.Write(baseAddr, -42);

        var service = new DynamicStructureService(_memory);

        // Act
        var structure = service.Read<SimpleTestStruct>(baseAddr);
        var value = structure.GetIntValue();

        // Assert
        Assert.Equal(-42, value);
    }

    [Fact]
    public void DynamicStructure_CanReadMaxValues()
    {
        // Arrange
        var baseAddr = (MemoryPointer)0x1200UL;
        _memory.Write(baseAddr, int.MaxValue);
        _memory.Write(baseAddr + 0x4, uint.MaxValue);
        _memory.Write(baseAddr + 0x8, long.MaxValue);
        _memory.Write(baseAddr + 0x10, ulong.MaxValue);

        var service = new DynamicStructureService(_memory);

        // Act
        var structure = service.Read<SimpleTestStruct>(baseAddr);

        // Assert
        Assert.Equal(int.MaxValue, structure.GetIntValue());
        Assert.Equal(uint.MaxValue, structure.GetUIntValue());
        Assert.Equal(long.MaxValue, structure.GetLongValue());
        Assert.Equal(ulong.MaxValue, structure.GetPointerValue());
    }

    #endregion
}
