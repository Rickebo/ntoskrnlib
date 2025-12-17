using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DEFERRED_PFNS_TO_FREE")]
    public sealed class MiDeferredPfnsToFree : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListHead { get => ReadStructure<ListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(16UL)]
        public ulong NumberOfPages { get => ReadHere<ulong>(nameof(NumberOfPages)); set => WriteHere(nameof(NumberOfPages), value); }

        [Offset(24UL)]
        public uint TbFlushStamp { get => ReadHere<uint>(nameof(TbFlushStamp)); set => WriteHere(nameof(TbFlushStamp), value); }

        public MiDeferredPfnsToFree(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDeferredPfnsToFree>();
        }
    }
}