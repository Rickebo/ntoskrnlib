using ntoskrnlib.Structure;
using Xunit;

namespace ntoskrnlib.Tests;

/// <summary>
/// Tests for DynamicArray helper class
/// </summary>
public class DynamicArrayTests : TestFixtureBase
{
    [Fact]
    public void DynamicArray_GetSingleElement_ShouldReturnCorrectValue()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        
        // Write array of integers
        memory.Write(arrayAddress + 0x0, 10);
        memory.Write(arrayAddress + 0x4, 20);
        memory.Write(arrayAddress + 0x8, 30);
        memory.Write(arrayAddress + 0xC, 40);
        
        var service = new DynamicStructureService(memory);
        var array = service.Read<DynamicArray>(arrayAddress);

        // Act & Assert
        Assert.Equal(10, array.Get<int>(0));
        Assert.Equal(20, array.Get<int>(1));
        Assert.Equal(30, array.Get<int>(2));
        Assert.Equal(40, array.Get<int>(3));
    }

    [Fact]
    public void DynamicArray_GetRange_ShouldReturnMultipleElements()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        
        // Write array of integers
        memory.WriteSequential(arrayAddress, 100, 200, 300, 400, 500);
        
        var service = new DynamicStructureService(memory);
        var array = service.Read<DynamicArray>(arrayAddress);

        // Act
        var range = array.GetRange<int>(5);

        // Assert
        Assert.Equal(5, range.Length);
        Assert.Equal(100, range[0]);
        Assert.Equal(200, range[1]);
        Assert.Equal(300, range[2]);
        Assert.Equal(400, range[3]);
        Assert.Equal(500, range[4]);
    }

    [Fact]
    public void DynamicArray_WithLongValues_ShouldHandleCorrectly()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        
        memory.WriteSequential(arrayAddress, 
            1111111111L, 2222222222L, 3333333333L);
        
        var service = new DynamicStructureService(memory);
        var array = service.Read<DynamicArray>(arrayAddress);

        // Act
        var val0 = array.Get<long>(0);
        var val1 = array.Get<long>(1);
        var val2 = array.Get<long>(2);

        // Assert
        Assert.Equal(1111111111L, val0);
        Assert.Equal(2222222222L, val1);
        Assert.Equal(3333333333L, val2);
    }

    [Fact]
    public void DynamicArray_WithByteValues_ShouldHandleSmallTypes()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        
        memory.WriteSequential(arrayAddress, 
            (byte)0x11, (byte)0x22, (byte)0x33, (byte)0x44, (byte)0x55);
        
        var service = new DynamicStructureService(memory);
        var array = service.Read<DynamicArray>(arrayAddress);

        // Act
        var range = array.GetRange<byte>(5);

        // Assert
        Assert.Equal(5, range.Length);
        Assert.Equal(0x11, range[0]);
        Assert.Equal(0x22, range[1]);
        Assert.Equal(0x33, range[2]);
        Assert.Equal(0x44, range[3]);
        Assert.Equal(0x55, range[4]);
    }

    [Fact]
    public void DynamicArray_GetRangeWithZeroLength_ShouldReturnEmptyArray()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        var service = new DynamicStructureService(memory);
        var array = service.Read<DynamicArray>(arrayAddress);

        // Act
        var range = array.GetRange<int>(0);

        // Assert
        Assert.NotNull(range);
        Assert.Empty(range);
    }

    [Fact]
    public void DynamicArray_WithStructValues_ShouldReadCorrectly()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        
        // Create a struct for testing
        var testStruct1 = new TestStruct { X = 10, Y = 20 };
        var testStruct2 = new TestStruct { X = 30, Y = 40 };
        var testStruct3 = new TestStruct { X = 50, Y = 60 };
        
        memory.WriteSequential(arrayAddress, testStruct1, testStruct2, testStruct3);
        
        var service = new DynamicStructureService(memory);
        var array = service.Read<DynamicArray>(arrayAddress);

        // Act
        var result1 = array.Get<TestStruct>(0);
        var result2 = array.Get<TestStruct>(1);
        var result3 = array.Get<TestStruct>(2);

        // Assert
        Assert.Equal(10, result1.X);
        Assert.Equal(20, result1.Y);
        Assert.Equal(30, result2.X);
        Assert.Equal(40, result2.Y);
        Assert.Equal(50, result3.X);
        Assert.Equal(60, result3.Y);
    }

    [Fact]
    public void DynamicArray_GetRangeWithStructs_ShouldReturnAllElements()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        
        var structs = new[]
        {
            new TestStruct { X = 1, Y = 2 },
            new TestStruct { X = 3, Y = 4 },
            new TestStruct { X = 5, Y = 6 }
        };
        
        memory.WriteSequential(arrayAddress, structs);
        
        var service = new DynamicStructureService(memory);
        var array = service.Read<DynamicArray>(arrayAddress);

        // Act
        var range = array.GetRange<TestStruct>(3);

        // Assert
        Assert.Equal(3, range.Length);
        for (int i = 0; i < 3; i++)
        {
            Assert.Equal(structs[i].X, range[i].X);
            Assert.Equal(structs[i].Y, range[i].Y);
        }
    }

    [Fact]
    public void DynamicArray_AtDifferentAddresses_ShouldBeIndependent()
    {
        // Arrange
        var memory = new TestMemorySource(2048);
        var array1Address = (MemoryPointer)0x100UL;
        var array2Address = (MemoryPointer)0x500UL;
        
        memory.WriteSequential(array1Address, 10, 20, 30);
        memory.WriteSequential(array2Address, 40, 50, 60);
        
        var service = new DynamicStructureService(memory);
        var array1 = service.Read<DynamicArray>(array1Address);
        var array2 = service.Read<DynamicArray>(array2Address);

        // Act & Assert
        Assert.Equal(10, array1.Get<int>(0));
        Assert.Equal(20, array1.Get<int>(1));
        Assert.Equal(30, array1.Get<int>(2));
        
        Assert.Equal(40, array2.Get<int>(0));
        Assert.Equal(50, array2.Get<int>(1));
        Assert.Equal(60, array2.Get<int>(2));
    }

    [Fact]
    public void DynamicArray_WithMixedSizedTypes_ShouldCalculateOffsetsCorrectly()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var arrayAddress = (MemoryPointer)0x100UL;
        
        // Test with different sized types at the same address
        // First as int array
        memory.WriteSequential(arrayAddress, 1, 2, 3, 4);
        
        var service = new DynamicStructureService(memory);
        var intArray = service.Read<DynamicArray>(arrayAddress);
        
        var int0 = intArray.Get<int>(0);
        var int1 = intArray.Get<int>(1);
        
        // Now interpret same memory as byte array
        var byteArray = service.Read<DynamicArray>(arrayAddress);
        var byte0 = byteArray.Get<byte>(0);
        var byte4 = byteArray.Get<byte>(4); // Skip 4 bytes to get to second int

        // Act & Assert
        Assert.Equal(1, int0);
        Assert.Equal(2, int1);
        // First byte of first int (little endian)
        Assert.Equal(1, byte0);
        // First byte of second int
        Assert.Equal(2, byte4);
    }

    // Helper struct for testing
    private struct TestStruct
    {
        public int X;
        public int Y;
    }
}
