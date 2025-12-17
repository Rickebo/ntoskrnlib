using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CACHED_KSTACK_LIST")]
    public sealed class CachedKstackList : DynamicStructure
    {
        [Offset(0UL)]
        public SlistHeader SListHead { get => ReadStructure<SlistHeader>(nameof(SListHead)); set => WriteStructure(nameof(SListHead), value); }

        [Offset(16UL)]
        public MiKstackAllocations Counters { get => ReadStructure<MiKstackAllocations>(nameof(Counters)); set => WriteStructure(nameof(Counters), value); }

        [Offset(32UL)]
        public uint CurrentIndex { get => ReadHere<uint>(nameof(CurrentIndex)); set => WriteHere(nameof(CurrentIndex), value); }

        [Offset(36UL)]
        public uint InUseAtOnce { get => ReadHere<uint>(nameof(InUseAtOnce)); set => WriteHere(nameof(InUseAtOnce), value); }

        [Offset(40UL)]
        public uint MinimumFree { get => ReadHere<uint>(nameof(MinimumFree)); set => WriteHere(nameof(MinimumFree), value); }

        [Offset(44UL)]
        public byte NonIdealStacksPresent { get => ReadHere<byte>(nameof(NonIdealStacksPresent)); set => WriteHere(nameof(NonIdealStacksPresent), value); }

        public CachedKstackList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CachedKstackList>();
        }
    }
}