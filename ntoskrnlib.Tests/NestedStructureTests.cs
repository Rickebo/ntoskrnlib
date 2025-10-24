using ntoskrnlib.Structure;
using Xunit;

namespace ntoskrnlib.Tests;

/// <summary>
/// Tests for nested structures and pointer dereferencing
/// </summary>
public class NestedStructureTests : TestFixtureBase
{
    [Fact]
    public void NestedStructure_WithValidChildPointer_ShouldReadChild()
    {
        // Arrange
        var memory = new TestMemorySource(2048);
        var parentAddress = (MemoryPointer)0x100UL;
        var childAddress = (MemoryPointer)0x500UL;
        
        // Setup parent structure
        memory.Write(parentAddress + 0x0, 42);              // Parent ID
        memory.Write(parentAddress + 0x8, childAddress.Value); // Child pointer
        
        // Setup child structure
        memory.Write(childAddress + 0x0, 999);              // Child IntValue
        memory.Write(childAddress + 0x8, 123456L);          // Child LongValue
        
        var service = new DynamicStructureService(memory);
        var parent = service.Read<NestedTestStruct>(parentAddress);

        // Act
        var parentId = parent.GetId();
        var childPtr = parent.GetChildPointer();
        var child = parent.GetChild();
        var childValue = child.GetIntValue();
        var childLongValue = child.GetLongValue();

        // Assert
        Assert.Equal(42, parentId);
        Assert.Equal(childAddress.Value, childPtr);
        Assert.NotNull(child);
        Assert.Equal(999, childValue);
        Assert.Equal(123456L, childLongValue);
    }

    [Fact]
    public void NestedStructure_WithNullChildPointer_ShouldThrowException()
    {
        // Arrange
        var memory = new TestMemorySource(2048);
        var parentAddress = (MemoryPointer)0x100UL;
        
        memory.Write(parentAddress + 0x0, 42);
        memory.Write(parentAddress + 0x8, 0UL); // Null pointer
        
        var service = new DynamicStructureService(memory);
        var parent = service.Read<NestedTestStruct>(parentAddress);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => parent.GetChild());
    }

    [Fact]
    public void NestedStructure_WithMultipleLevels_ShouldDereferenceCorrectly()
    {
        // Arrange
        var memory = new TestMemorySource(4096);
        var level0Address = (MemoryPointer)0x100UL;
        var level1Address = (MemoryPointer)0x500UL;
        var level2Address = (MemoryPointer)0x900UL;

        // Level 0: Parent with pointer to Level 1
        memory.Write(level0Address + 0x0, 1);
        memory.Write(level0Address + 0x8, level1Address.Value);

        // Level 1: Nested child with pointer to Level 2
        memory.Write(level1Address + 0x0, 2);
        memory.Write(level1Address + 0x8, level2Address.Value);

        // Level 2: Simple struct with actual data
        memory.Write(level2Address + 0x0, 777);
        memory.Write(level2Address + 0x8, 888888L);

        var service = new DynamicStructureService(memory);
        var level0 = service.Read<NestedTestStruct>(level0Address);

        // Act
        var level1 = service.Read<NestedTestStruct>((MemoryPointer)level0.GetChildPointer());
        var level2 = service.Read<SimpleTestStruct>((MemoryPointer)level1.GetChildPointer());

        // Assert
        Assert.Equal(1, level0.GetId());
        Assert.Equal(2, level1.GetId());
        Assert.Equal(777, level2.GetIntValue());
        Assert.Equal(888888L, level2.GetLongValue());
    }

    [Fact]
    public void MultiLevelOffset_WithPointerChain_ShouldDereferenceCorrectly()
    {
        // This tests the [Offset(0x0, 0x10)] multi-level offset functionality
        
        // Arrange
        var memory = new TestMemorySource(4096);
        var baseAddress = (MemoryPointer)0x100UL;
        var intermediateAddress = (MemoryPointer)0x500UL;
        
        // Base address contains pointer to intermediate
        memory.Write(baseAddress + 0x0, intermediateAddress.Value);
        
        // Intermediate address + 0x10 contains the actual value
        memory.Write(intermediateAddress + 0x10, 12345);
        
        var service = new DynamicStructureService(memory);
        var structure = service.Read<MultiLevelTestStruct>(baseAddress);

        // Act
        var value = structure.GetDereferencedValue();

        // Assert
        Assert.Equal(12345, value);
    }

    [Fact]
    public void ReadStructure_FromDifferentBaseAddresses_ShouldBeIndependent()
    {
        // Arrange
        var memory = new TestMemorySource(4096);
        var parent1Address = (MemoryPointer)0x100UL;
        var parent2Address = (MemoryPointer)0x200UL;
        var child1Address = (MemoryPointer)0x500UL;
        var child2Address = (MemoryPointer)0x600UL;
        
        // Setup first parent-child pair
        memory.Write(parent1Address + 0x0, 1);
        memory.Write(parent1Address + 0x8, child1Address.Value);
        memory.Write(child1Address + 0x0, 100);
        
        // Setup second parent-child pair
        memory.Write(parent2Address + 0x0, 2);
        memory.Write(parent2Address + 0x8, child2Address.Value);
        memory.Write(child2Address + 0x0, 200);
        
        var service = new DynamicStructureService(memory);

        // Act
        var parent1 = service.Read<NestedTestStruct>(parent1Address);
        var parent2 = service.Read<NestedTestStruct>(parent2Address);
        var child1 = parent1.GetChild();
        var child2 = parent2.GetChild();

        // Assert
        Assert.Equal(1, parent1.GetId());
        Assert.Equal(2, parent2.GetId());
        Assert.Equal(100, child1.GetIntValue());
        Assert.Equal(200, child2.GetIntValue());
    }

    [Fact]
    public void NestedStructure_BaseAddressProperty_ShouldReflectActualAddress()
    {
        // Arrange
        var memory = new TestMemorySource(2048);
        var parentAddress = (MemoryPointer)0x100UL;
        var childAddress = (MemoryPointer)0x500UL;
        
        memory.Write(parentAddress + 0x0, 42);
        memory.Write(parentAddress + 0x8, childAddress.Value);
        memory.Write(childAddress + 0x0, 999);
        
        var service = new DynamicStructureService(memory);
        var parent = service.Read<NestedTestStruct>(parentAddress);
        var child = parent.GetChild();

        // Act & Assert
        Assert.Equal(parentAddress, parent.BaseAddress);
        Assert.Equal(childAddress, child.BaseAddress);
    }

    [Fact]
    public void NestedStructure_WithCircularReference_ShouldNotCauseStackOverflow()
    {
        // This is more of a sanity test - circular references would require
        // explicit reading, so they shouldn't cause automatic recursion
        
        // Arrange
        var memory = new TestMemorySource(2048);
        var address1 = (MemoryPointer)0x100UL;
        var address2 = (MemoryPointer)0x200UL;
        
        // Create circular reference
        memory.Write(address1 + 0x0, 1);
        memory.Write(address1 + 0x8, address2.Value); // Points to address2
        
        memory.Write(address2 + 0x0, 2);
        memory.Write(address2 + 0x8, address1.Value); // Points back to address1
        
        var service = new DynamicStructureService(memory);

        // Act & Assert - Should not throw or cause stack overflow
        var struct1 = service.Read<NestedTestStruct>(address1);
        var struct2 = service.Read<NestedTestStruct>((MemoryPointer)struct1.GetChildPointer());

        Assert.Equal(1, struct1.GetId());
        Assert.Equal(2, struct2.GetId());
        
        // We could follow the circular reference again, but we stop here
        // This demonstrates that circular references don't automatically cause issues
    }
}
