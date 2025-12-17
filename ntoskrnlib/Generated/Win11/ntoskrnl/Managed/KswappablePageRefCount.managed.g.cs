using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSWAPPABLE_PAGE_REF_COUNT")]
    public sealed class KswappablePageRefCount : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public ulong Resident { get => ReadHere<ulong>(nameof(Resident)); set => WriteHere(nameof(Resident), value); }

        [Offset(0UL)]
        public ulong RefCount { get => ReadHere<ulong>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        public KswappablePageRefCount(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KswappablePageRefCount>();
        }
    }
}