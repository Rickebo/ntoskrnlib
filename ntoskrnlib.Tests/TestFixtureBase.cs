using System.Runtime.CompilerServices;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Tests;

/// <summary>
/// Base class for test fixtures that ensures all test structures are registered
/// </summary>
public abstract class TestFixtureBase
{
    static TestFixtureBase()
    {
        // Ensure all test structures are registered by forcing static constructors to run
        RuntimeHelpers.RunClassConstructor(typeof(SimpleTestStruct).TypeHandle);
        RuntimeHelpers.RunClassConstructor(typeof(ZeroReflectionTestStruct).TypeHandle);
        RuntimeHelpers.RunClassConstructor(typeof(NestedTestStruct).TypeHandle);
        RuntimeHelpers.RunClassConstructor(typeof(MultiLevelTestStruct).TypeHandle);
        // KeyBasedTestStruct is not registered here as it requires an IOffsetParser to be configured
        RuntimeHelpers.RunClassConstructor(typeof(DynamicArray).TypeHandle);
    }
}
