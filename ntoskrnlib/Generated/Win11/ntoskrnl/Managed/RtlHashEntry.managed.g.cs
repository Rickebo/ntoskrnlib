using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_HASH_ENTRY")]
    public sealed class RtlHashEntry : DynamicStructure
    {
        [Offset(0UL)]
        public SingleListEntry BucketLink { get => ReadStructure<SingleListEntry>(nameof(BucketLink)); set => WriteStructure(nameof(BucketLink), value); }

        [Offset(8UL)]
        public ulong Key { get => ReadHere<ulong>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        public RtlHashEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHashEntry>();
        }
    }
}