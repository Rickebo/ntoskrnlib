using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_MEM_POLICIES")]
    public sealed class HeapLfhMemPolicies : DynamicStructure
    {
        [Offset(0UL)]
        public uint DisableAffinity { get => ReadHere<uint>(nameof(DisableAffinity)); set => WriteHere(nameof(DisableAffinity), value); }

        [Offset(0UL)]
        public uint SlowSubsegmentGrowth { get => ReadHere<uint>(nameof(SlowSubsegmentGrowth)); set => WriteHere(nameof(SlowSubsegmentGrowth), value); }

        [Offset(0UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public uint AllPolicies { get => ReadHere<uint>(nameof(AllPolicies)); set => WriteHere(nameof(AllPolicies), value); }

        public HeapLfhMemPolicies(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhMemPolicies>();
        }
    }
}