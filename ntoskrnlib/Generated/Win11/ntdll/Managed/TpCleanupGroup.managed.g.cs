using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_CLEANUP_GROUP")]
    public sealed class TpCleanupGroup : DynamicStructure
    {
        [Offset(0UL)]
        public TppRefcount Refcount { get => ReadStructure<TppRefcount>(nameof(Refcount)); set => WriteStructure(nameof(Refcount), value); }

        [Offset(4UL)]
        public int Released { get => ReadHere<int>(nameof(Released)); set => WriteHere(nameof(Released), value); }

        [Offset(8UL)]
        public RtlSrwlock MemberLock { get => ReadStructure<RtlSrwlock>(nameof(MemberLock)); set => WriteStructure(nameof(MemberLock), value); }

        [Offset(16UL)]
        public ListEntry MemberList { get => ReadStructure<ListEntry>(nameof(MemberList)); set => WriteStructure(nameof(MemberList), value); }

        [Offset(32UL)]
        public TppBarrier Barrier { get => ReadStructure<TppBarrier>(nameof(Barrier)); set => WriteStructure(nameof(Barrier), value); }

        [Offset(56UL)]
        public RtlSrwlock CleanupLock { get => ReadStructure<RtlSrwlock>(nameof(CleanupLock)); set => WriteStructure(nameof(CleanupLock), value); }

        [Offset(64UL)]
        public ListEntry CleanupList { get => ReadStructure<ListEntry>(nameof(CleanupList)); set => WriteStructure(nameof(CleanupList), value); }

        public TpCleanupGroup(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpCleanupGroup>();
        }
    }
}