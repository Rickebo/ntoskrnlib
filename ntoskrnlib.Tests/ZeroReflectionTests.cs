using ntoskrnlib.Structure;
using Xunit;

namespace ntoskrnlib.Tests;

/// <summary>
/// Tests for zero-reflection offset registration
/// </summary>
public class ZeroReflectionTests : TestFixtureBase
{
    [Fact]
    public void ZeroReflectionStructure_ShouldReadValuesCorrectly()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x200UL;
        
        memory.Write(address + 0x0, 111);
        memory.Write(address + 0x8, 222222L);
        memory.Write(address + 0x10, 333333U);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<ZeroReflectionTestStruct>(address);

        // Act & Assert
        Assert.Equal(111, structure.GetValue1());
        Assert.Equal(222222L, structure.GetValue2());
        Assert.Equal(333333U, structure.GetValue3());
    }

    [Fact]
    public void ZeroReflectionStructure_WithoutOffsetAttributes_ShouldStillWork()
    {
        // This test verifies that the zero-reflection approach doesn't require
        // [Offset] attributes on properties
        
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x200UL;
        
        memory.Write(address + 0x0, 777);
        memory.Write(address + 0x8, 888888L);
        memory.Write(address + 0x10, 999999U);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<ZeroReflectionTestStruct>(address);

        // Act
        var value1 = structure.GetValue1();
        var value2 = structure.GetValue2();
        var value3 = structure.GetValue3();

        // Assert - Should work even without [Offset] attributes
        Assert.Equal(777, value1);
        Assert.Equal(888888L, value2);
        Assert.Equal(999999U, value3);
    }

    [Fact]
    public void ZeroReflectionStructure_WithNegativeValues_ShouldHandleCorrectly()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x200UL;
        
        memory.Write(address + 0x0, -100);
        memory.Write(address + 0x8, -200000L);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<ZeroReflectionTestStruct>(address);

        // Act & Assert
        Assert.Equal(-100, structure.GetValue1());
        Assert.Equal(-200000L, structure.GetValue2());
    }

    [Fact]
    public void ZeroReflectionStructure_ComparedToReflectionBased_ShouldProduceSameResults()
    {
        // This test verifies that zero-reflection and reflection-based approaches
        // produce identical results for the same memory layout
        
        // Arrange
        var memory = new TestMemorySource(2048);
        var address1 = (MemoryPointer)0x100UL;
        var address2 = (MemoryPointer)0x500UL;
        
        // Write same data to both locations
        memory.Write(address1 + 0x0, 42);
        memory.Write(address1 + 0x8, 123456L);
        
        memory.Write(address2 + 0x0, 42);
        memory.Write(address2 + 0x8, 123456L);
        
        var service = new DynamicStructureService(memory);
        var reflectionStruct = service.Read<SimpleTestStruct>(address1);
        var zeroReflectionStruct = service.Read<ZeroReflectionTestStruct>(address2);

        // Act
        var reflectionInt = reflectionStruct.GetIntValue();
        var reflectionLong = reflectionStruct.GetLongValue();
        var zeroInt = zeroReflectionStruct.GetValue1();
        var zeroLong = zeroReflectionStruct.GetValue2();

        // Assert - Both approaches should read the same values
        Assert.Equal(reflectionInt, zeroInt);
        Assert.Equal(reflectionLong, zeroLong);
    }

    [Fact]
    public void ZeroReflectionStructure_AtDifferentAddresses_ShouldReadIndependently()
    {
        // Arrange
        var memory = new TestMemorySource(2048);
        var address1 = (MemoryPointer)0x100UL;
        var address2 = (MemoryPointer)0x500UL;
        
        memory.Write(address1 + 0x0, 111);
        memory.Write(address1 + 0x8, 222L);
        
        memory.Write(address2 + 0x0, 333);
        memory.Write(address2 + 0x8, 444L);
        
        var service = new DynamicStructureService(memory);

        // Act
        var struct1 = service.Read<ZeroReflectionTestStruct>(address1);
        var struct2 = service.Read<ZeroReflectionTestStruct>(address2);

        // Assert
        Assert.Equal(111, struct1.GetValue1());
        Assert.Equal(222L, struct1.GetValue2());
        Assert.Equal(333, struct2.GetValue1());
        Assert.Equal(444L, struct2.GetValue2());
    }
}
