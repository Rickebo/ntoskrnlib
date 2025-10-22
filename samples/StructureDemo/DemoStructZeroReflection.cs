using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace StructureDemo;

[DynamicStructure("demo!DEMO_STRUCT_ZR")]
public sealed class DemoStructZeroReflection : DynamicStructure
{
    // Property exists for naming; offsets supplied explicitly.
    public int Value { get; }

    public DemoStructZeroReflection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress) { }

    static DemoStructZeroReflection()
    {
        var offsets = new Dictionary<string, ulong[]>
        {
            { nameof(Value), new []{ 0x0UL } }
        };
        Register<DemoStructZeroReflection>((mem, ptr) => new DemoStructZeroReflection(mem, ptr), offsets);
    }

    public int GetValue() => ReadHere<int>(nameof(Value));
}

