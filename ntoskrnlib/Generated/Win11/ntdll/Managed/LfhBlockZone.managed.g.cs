using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LFH_BLOCK_ZONE")]
    public sealed class LfhBlockZone : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public int NextIndex { get => ReadHere<int>(nameof(NextIndex)); set => WriteHere(nameof(NextIndex), value); }

        public LfhBlockZone(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LfhBlockZone>();
        }
    }
}