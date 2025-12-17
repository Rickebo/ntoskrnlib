using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_PROCESS_CONTEXT")]
    public sealed class AlpcProcessContext : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(8UL)]
        public ListEntry ViewListHead { get => ReadStructure<ListEntry>(nameof(ViewListHead)); set => WriteStructure(nameof(ViewListHead), value); }

        [Offset(24UL)]
        public ulong PagedPoolQuotaCache { get => ReadHere<ulong>(nameof(PagedPoolQuotaCache)); set => WriteHere(nameof(PagedPoolQuotaCache), value); }

        public AlpcProcessContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcProcessContext>();
        }
    }
}