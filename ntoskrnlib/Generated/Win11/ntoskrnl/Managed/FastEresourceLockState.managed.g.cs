using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!FAST_ERESOURCE_LOCK_STATE")]
    public sealed class FastEresourceLockState : DynamicStructure
    {
        [Offset(0UL)]
        public long Value { get => ReadHere<long>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public long Exclusive { get => ReadHere<long>(nameof(Exclusive)); set => WriteHere(nameof(Exclusive), value); }

        [Offset(0UL)]
        public long Conflict { get => ReadHere<long>(nameof(Conflict)); set => WriteHere(nameof(Conflict), value); }

        [Offset(0UL)]
        public long ShareCount { get => ReadHere<long>(nameof(ShareCount)); set => WriteHere(nameof(ShareCount), value); }

        public FastEresourceLockState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FastEresourceLockState>();
        }
    }
}