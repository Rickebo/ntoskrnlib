using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SHARED_CACHE_MAP_LIST_CURSOR")]
    public sealed class SharedCacheMapListCursor : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry SharedCacheMapLinks { get => ReadStructure<ListEntry>(nameof(SharedCacheMapLinks)); set => WriteStructure(nameof(SharedCacheMapLinks), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public SharedCacheMapListCursor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SharedCacheMapListCursor>();
        }
    }
}