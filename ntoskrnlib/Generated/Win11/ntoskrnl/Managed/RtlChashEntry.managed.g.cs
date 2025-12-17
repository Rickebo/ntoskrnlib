using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_CHASH_ENTRY")]
    public sealed class RtlChashEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Key { get => ReadHere<ulong>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        public RtlChashEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlChashEntry>();
        }
    }
}