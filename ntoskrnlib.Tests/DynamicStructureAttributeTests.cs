using ntoskrnlib.Structure;
using Xunit;

namespace ntoskrnlib.Tests;

/// <summary>
/// Tests for DynamicStructure attribute validation and registration
/// </summary>
public class DynamicStructureAttributeTests : TestFixtureBase
{

    [Fact]
    public void StructureWithAttribute_ShouldRegisterSuccessfully()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        
        // Act - Constructor call triggers static registration
        var service = new DynamicStructureService(memory);
        var instance = service.Read<SimpleTestStruct>(address);

        // Assert
        Assert.NotNull(instance);
        Assert.Equal(address, instance.BaseAddress);
    }

    [Fact]
    public void StructureWithoutAttribute_ShouldThrowException()
    {
        // Arrange & Act & Assert
        var exception = Assert.Throws<StructureInitializationException>(() =>
        {
            InvalidTestStruct.TryRegister();
        });

        Assert.Contains("DynamicStructure", exception.Message);
    }

    [Fact]
    public void RegisteredStructure_ShouldHaveCorrectBackingSymbolName()
    {
        // Arrange
        var attribute = (DynamicStructureAttribute?)Attribute.GetCustomAttribute(
            typeof(SimpleTestStruct), 
            typeof(DynamicStructureAttribute));

        // Act & Assert
        Assert.NotNull(attribute);
        Assert.Equal("test!SIMPLE_STRUCT", attribute.BackingSymbolName);
    }

    [Fact]
    public void ZeroReflectionStructure_ShouldRegisterSuccessfully()
    {
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x200UL;

        // Act
        var service = new DynamicStructureService(memory);
        var instance = service.Read<ZeroReflectionTestStruct>(address);

        // Assert
        Assert.NotNull(instance);
        Assert.Equal(address, instance.BaseAddress);
    }

    [Fact]
    public void MultipleRegistrations_ShouldNotThrow()
    {
        // This test ensures that static constructors can be called multiple times
        // without causing issues (idempotent registration)
        
        // Arrange
        var memory = new TestMemorySource(1024);
        var address = (MemoryPointer)0x100UL;
        var service = new DynamicStructureService(memory);

        // Act - Read multiple times to potentially trigger static constructor again
        var instance1 = service.Read<SimpleTestStruct>(address);
        var instance2 = service.Read<SimpleTestStruct>(address);
        var instance3 = service.Read<SimpleTestStruct>(address);

        // Assert
        Assert.NotNull(instance1);
        Assert.NotNull(instance2);
        Assert.NotNull(instance3);
    }

    [Fact]
    public void DifferentStructureTypes_ShouldRegisterIndependently()
    {
        // Arrange
        var memory = new TestMemorySource(2048);
        var address1 = (MemoryPointer)0x100UL;
        var address2 = (MemoryPointer)0x500UL;
        var service = new DynamicStructureService(memory);

        // Act
        var simple = service.Read<SimpleTestStruct>(address1);
        var zeroReflection = service.Read<ZeroReflectionTestStruct>(address2);
        var nested = service.Read<NestedTestStruct>(address1);

        // Assert
        Assert.NotNull(simple);
        Assert.NotNull(zeroReflection);
        Assert.NotNull(nested);
        Assert.IsType<SimpleTestStruct>(simple);
        Assert.IsType<ZeroReflectionTestStruct>(zeroReflection);
        Assert.IsType<NestedTestStruct>(nested);
    }
}
