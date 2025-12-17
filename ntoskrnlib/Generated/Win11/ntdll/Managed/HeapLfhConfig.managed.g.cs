using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_CONFIG")]
    public sealed class HeapLfhConfig : DynamicStructure
    {
        [Offset(0UL)]
        public RtlHpLfhConfig Global { get => ReadStructure<RtlHpLfhConfig>(nameof(Global)); set => WriteStructure(nameof(Global), value); }

        [Offset(4UL)]
        public uint EnablePrivateSlots { get => ReadHere<uint>(nameof(EnablePrivateSlots)); set => WriteHere(nameof(EnablePrivateSlots), value); }

        public HeapLfhConfig(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhConfig>();
        }
    }
}