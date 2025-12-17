using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_ACTIVE_TIME_ACCOUNTING")]
    public sealed class PopFxActiveTimeAccounting : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Total { get => ReadHere<ulong>(nameof(Total)); set => WriteHere(nameof(Total), value); }

        [Offset(8UL)]
        public ulong Unattributed { get => ReadHere<ulong>(nameof(Unattributed)); set => WriteHere(nameof(Unattributed), value); }

        [Offset(16UL)]
        [Length(5)]
        public DynamicArray Buckets { get => ReadStructure<DynamicArray>(nameof(Buckets)); set => WriteStructure(nameof(Buckets), value); }

        [Offset(56UL)]
        [Length(5)]
        public DynamicArray PerBucket { get => ReadStructure<DynamicArray>(nameof(PerBucket)); set => WriteStructure(nameof(PerBucket), value); }

        public PopFxActiveTimeAccounting(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxActiveTimeAccounting>();
        }
    }
}