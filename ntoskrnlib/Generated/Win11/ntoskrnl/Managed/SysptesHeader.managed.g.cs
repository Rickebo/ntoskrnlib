using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SYSPTES_HEADER")]
    public sealed class SysptesHeader : DynamicStructure
    {
        [Offset(0UL)]
        [Length(16)]
        public DynamicArray ListHead { get => ReadStructure<DynamicArray>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(256UL)]
        public ulong Count { get => ReadHere<ulong>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(264UL)]
        public ulong NumberOfEntries { get => ReadHere<ulong>(nameof(NumberOfEntries)); set => WriteHere(nameof(NumberOfEntries), value); }

        [Offset(272UL)]
        public ulong NumberOfEntriesPeak { get => ReadHere<ulong>(nameof(NumberOfEntriesPeak)); set => WriteHere(nameof(NumberOfEntriesPeak), value); }

        public SysptesHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SysptesHeader>();
        }
    }
}