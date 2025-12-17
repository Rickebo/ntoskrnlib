using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_BLOCK_SLIST")]
    public sealed class HeapLfhBlockSlist : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Next { get => ReadHere<ushort>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        public HeapLfhBlockSlist(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhBlockSlist>();
        }
    }
}