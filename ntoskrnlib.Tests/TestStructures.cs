using ntoskrnlib.Structure;

namespace ntoskrnlib.Tests;

/// <summary>
/// Simple test structure with reflection-based offset registration
/// </summary>
[DynamicStructure("test!SIMPLE_STRUCT")]
public sealed class SimpleTestStruct : DynamicStructure
{
    [Offset(0x0)] public int IntValue { get; }
    [Offset(0x4)] public uint UIntValue { get; }
    [Offset(0x8)] public long LongValue { get; }
    [Offset(0x10)] public ulong PointerValue { get; }
    [Offset(0x18)] public byte ByteValue { get; }
    [Offset(0x19)] public short ShortValue { get; }

    public SimpleTestStruct(IMemorySource memory, MemoryPointer baseAddress)
        : base(memory, baseAddress)
    {
    }

    static SimpleTestStruct()
    {
        Register<SimpleTestStruct>((mem, ptr) => new SimpleTestStruct(mem, ptr));
    }

    public int GetIntValue() => ReadHere<int>(nameof(IntValue));
    public uint GetUIntValue() => ReadHere<uint>(nameof(UIntValue));
    public long GetLongValue() => ReadHere<long>(nameof(LongValue));
    public ulong GetPointerValue() => ReadHere<ulong>(nameof(PointerValue));
    public byte GetByteValue() => ReadHere<byte>(nameof(ByteValue));
    public short GetShortValue() => ReadHere<short>(nameof(ShortValue));

    public void SetIntValue(int value) => WriteHere(nameof(IntValue), value);
    public void SetLongValue(long value) => WriteHere(nameof(LongValue), value);
}

/// <summary>
/// Test structure with zero-reflection offset registration
/// </summary>
[DynamicStructure("test!ZERO_REFLECTION_STRUCT")]
public sealed class ZeroReflectionTestStruct : DynamicStructure
{
    public int Value1 { get; }
    public long Value2 { get; }
    public uint Value3 { get; }

    public ZeroReflectionTestStruct(IMemorySource memory, MemoryPointer baseAddress)
        : base(memory, baseAddress)
    {
    }

    static ZeroReflectionTestStruct()
    {
        var offsets = new Dictionary<string, ulong[]>
        {
            { nameof(Value1), new[] { 0x0UL } },
            { nameof(Value2), new[] { 0x8UL } },
            { nameof(Value3), new[] { 0x10UL } }
        };

        Register<ZeroReflectionTestStruct>((mem, ptr) => new ZeroReflectionTestStruct(mem, ptr), offsets);
    }

    public int GetValue1() => ReadHere<int>(nameof(Value1));
    public long GetValue2() => ReadHere<long>(nameof(Value2));
    public uint GetValue3() => ReadHere<uint>(nameof(Value3));
}

/// <summary>
/// Test structure for nested structure tests
/// </summary>
[DynamicStructure("test!NESTED_STRUCT")]
public sealed class NestedTestStruct : DynamicStructure
{
    [Offset(0x0)] public int Id { get; }
    [Offset(0x8)] public ulong ChildPointer { get; }

    public NestedTestStruct(IMemorySource memory, MemoryPointer baseAddress)
        : base(memory, baseAddress)
    {
    }

    static NestedTestStruct()
    {
        Register<NestedTestStruct>((mem, ptr) => new NestedTestStruct(mem, ptr));
    }

    public int GetId() => ReadHere<int>(nameof(Id));
    public ulong GetChildPointer() => ReadHere<ulong>(nameof(ChildPointer));

    public SimpleTestStruct GetChild()
    {
        var childPtr = GetChildPointer();
        if (childPtr == 0)
            throw new InvalidOperationException("Child pointer is null");

        return ReadStructure<SimpleTestStruct>(nameof(ChildPointer));
    }
}

/// <summary>
/// Test structure with multiple offset levels (pointer dereferencing chain)
/// </summary>
[DynamicStructure("test!MULTI_LEVEL_STRUCT")]
public sealed class MultiLevelTestStruct : DynamicStructure
{
    [Offset(0x0, 0x10)] public int DereferencedValue { get; }

    public MultiLevelTestStruct(IMemorySource memory, MemoryPointer baseAddress)
        : base(memory, baseAddress)
    {
    }

    static MultiLevelTestStruct()
    {
        Register<MultiLevelTestStruct>((mem, ptr) => new MultiLevelTestStruct(mem, ptr));
    }

    public int GetDereferencedValue() => Read<int>(new[] { 0x0UL, 0x10UL });
}

/// <summary>
/// Test structure WITHOUT DynamicStructure attribute (for validation tests)
/// </summary>
public sealed class InvalidTestStruct : DynamicStructure
{
    [Offset(0x0)] public int Value { get; }

    public InvalidTestStruct(IMemorySource memory, MemoryPointer baseAddress)
        : base(memory, baseAddress)
    {
    }

    // This should fail registration due to missing [DynamicStructure] attribute
    public static void TryRegister()
    {
        Register<InvalidTestStruct>((mem, ptr) => new InvalidTestStruct(mem, ptr));
    }

    public int GetValue() => ReadHere<int>(nameof(Value));
}

/// <summary>
/// Test structure with string offset keys (requires IOffsetParser)
/// </summary>
[DynamicStructure("test!KEY_BASED_STRUCT")]
public sealed class KeyBasedTestStruct : DynamicStructure
{
    [Offset("Field1")] public int Field1 { get; }
    [Offset("Field2")] public long Field2 { get; }

    public KeyBasedTestStruct(IMemorySource memory, MemoryPointer baseAddress)
        : base(memory, baseAddress)
    {
    }

    static KeyBasedTestStruct()
    {
        Register<KeyBasedTestStruct>((mem, ptr) => new KeyBasedTestStruct(mem, ptr));
    }

    public int GetField1() => ReadHere<int>(nameof(Field1));
    public long GetField2() => ReadHere<long>(nameof(Field2));
}
