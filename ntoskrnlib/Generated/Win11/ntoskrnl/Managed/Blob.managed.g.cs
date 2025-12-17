using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BLOB")]
    public sealed class Blob : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ResourceList { get => ReadStructure<ListEntry>(nameof(ResourceList)); set => WriteStructure(nameof(ResourceList), value); }

        [Offset(0UL)]
        public SlistEntry FreeListEntry { get => ReadStructure<SlistEntry>(nameof(FreeListEntry)); set => WriteStructure(nameof(FreeListEntry), value); }

        [Offset(16UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(17UL)]
        public byte ResourceId { get => ReadHere<byte>(nameof(ResourceId)); set => WriteHere(nameof(ResourceId), value); }

        [Offset(18UL)]
        public short CachedReferences { get => ReadHere<short>(nameof(CachedReferences)); set => WriteHere(nameof(CachedReferences), value); }

        [Offset(24UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(32UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        public Blob(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Blob>();
        }
    }
}