using ntoskrnlib.Structure;
using Xunit;

namespace ntoskrnlib.Tests;

/// <summary>
/// Tests for reading and writing values using Offset attributes
/// </summary>
public class StructureReadWriteTests : TestFixtureBase
{
    [Fact]
    public void ReadInt_WithReflectionBasedOffset_ShouldReturnCorrectValue()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        var expectedValue = 12345;
        
        memory.Write(address, expectedValue);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act
        var actualValue = structure.GetIntValue();

        // Assert
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void ReadMultipleFields_WithDifferentOffsets_ShouldReturnCorrectValues()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        
        memory.Write(address + 0x0, 42);           // IntValue
        memory.Write(address + 0x4, 123456U);      // UIntValue
        memory.Write(address + 0x8, 9876543210L);  // LongValue
        memory.Write(address + 0x10, 0xDEADBEEFUL); // PointerValue
        memory.Write(address + 0x18, (byte)0xFF);   // ByteValue
        memory.Write(address + 0x19, (short)-1234); // ShortValue
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act & Assert
        Assert.Equal(42, structure.GetIntValue());
        Assert.Equal(123456U, structure.GetUIntValue());
        Assert.Equal(9876543210L, structure.GetLongValue());
        Assert.Equal(0xDEADBEEFUL, structure.GetPointerValue());
        Assert.Equal((byte)0xFF, structure.GetByteValue());
        Assert.Equal((short)-1234, structure.GetShortValue());
    }

    [Fact]
    public void WriteInt_WithReflectionBasedOffset_ShouldUpdateMemory()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act
        structure.SetIntValue(999);

        // Assert
        var actualValue = memory.Read<int>(address);
        Assert.Equal(999, actualValue);
    }

    [Fact]
    public void WriteAndRead_ShouldRoundTripCorrectly()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act
        structure.SetIntValue(555);
        structure.SetLongValue(777777L);

        // Assert
        Assert.Equal(555, structure.GetIntValue());
        Assert.Equal(777777L, structure.GetLongValue());
    }

    [Fact]
    public void ReadNegativeValues_ShouldHandleSignedTypes()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        
        memory.Write(address + 0x0, -12345);
        memory.Write(address + 0x8, -9876543210L);
        memory.Write(address + 0x19, (short)-32000);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act & Assert
        Assert.Equal(-12345, structure.GetIntValue());
        Assert.Equal(-9876543210L, structure.GetLongValue());
        Assert.Equal((short)-32000, structure.GetShortValue());
    }

    [Fact]
    public void ReadZeroValues_ShouldReturnZero()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        // Memory is already zeroed
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act & Assert
        Assert.Equal(0, structure.GetIntValue());
        Assert.Equal(0U, structure.GetUIntValue());
        Assert.Equal(0L, structure.GetLongValue());
        Assert.Equal(0UL, structure.GetPointerValue());
        Assert.Equal((byte)0, structure.GetByteValue());
        Assert.Equal((short)0, structure.GetShortValue());
    }

    [Fact]
    public void ReadMaxValues_ShouldHandleEdgeCases()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        
        memory.Write(address + 0x0, int.MaxValue);
        memory.Write(address + 0x4, uint.MaxValue);
        memory.Write(address + 0x8, long.MaxValue);
        memory.Write(address + 0x10, ulong.MaxValue);
        memory.Write(address + 0x18, byte.MaxValue);
        memory.Write(address + 0x19, short.MaxValue);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act & Assert
        Assert.Equal(int.MaxValue, structure.GetIntValue());
        Assert.Equal(uint.MaxValue, structure.GetUIntValue());
        Assert.Equal(long.MaxValue, structure.GetLongValue());
        Assert.Equal(ulong.MaxValue, structure.GetPointerValue());
        Assert.Equal(byte.MaxValue, structure.GetByteValue());
        Assert.Equal(short.MaxValue, structure.GetShortValue());
    }

    [Fact]
    public void ReadMinValues_ShouldHandleEdgeCases()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        
        memory.Write(address + 0x0, int.MinValue);
        memory.Write(address + 0x4, uint.MinValue);
        memory.Write(address + 0x8, long.MinValue);
        memory.Write(address + 0x10, ulong.MinValue);
        memory.Write(address + 0x18, byte.MinValue);
        memory.Write(address + 0x19, short.MinValue);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<SimpleTestStruct>(address);

        // Act & Assert
        Assert.Equal(int.MinValue, structure.GetIntValue());
        Assert.Equal(uint.MinValue, structure.GetUIntValue());
        Assert.Equal(long.MinValue, structure.GetLongValue());
        Assert.Equal(ulong.MinValue, structure.GetPointerValue());
        Assert.Equal(byte.MinValue, structure.GetByteValue());
        Assert.Equal(short.MinValue, structure.GetShortValue());
    }
}
