using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SLIST_HEADER")]
    public sealed class SlistHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Alignment { get => ReadHere<ulong>(nameof(Alignment)); set => WriteHere(nameof(Alignment), value); }

        [Offset(8UL)]
        public ulong Region { get => ReadHere<ulong>(nameof(Region)); set => WriteHere(nameof(Region), value); }

        [Offset(0UL)]
        public UnnamedTag HeaderX64 { get => ReadStructure<UnnamedTag>(nameof(HeaderX64)); set => WriteStructure(nameof(HeaderX64), value); }

        public SlistHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SlistHeader>();
        }
    }
}