using ntoskrnlib.Structure;

namespace StructureDemo;

[DynamicStructure("demo!DEMO_STRUCT")]
public sealed class DemoStruct : DynamicStructure
{
    // Property exists for [Offset] metadata only; value is read via helpers.
    [Offset(0x0)] public int Value { get; }

    public DemoStruct(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress) { }

    static DemoStruct()
    {
        // Uses reflection-assisted collection of [Offset] attributes once per type.
        Register<DemoStruct>((mem, ptr) => new DemoStruct(mem, ptr));
    }

    public int GetValue() => ReadHere<int>(nameof(Value));
}

