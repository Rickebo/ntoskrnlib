using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_HASH")]
    public sealed class MiPageHash : DynamicStructure
    {
        [Offset(0UL)]
        public uint HashValue { get => ReadHere<uint>(nameof(HashValue)); set => WriteHere(nameof(HashValue), value); }

        [Offset(4UL)]
        public uint PageFileOffset { get => ReadHere<uint>(nameof(PageFileOffset)); set => WriteHere(nameof(PageFileOffset), value); }

        [Offset(8UL)]
        public IntPtr OwningPte { get => ReadHere<IntPtr>(nameof(OwningPte)); set => WriteHere(nameof(OwningPte), value); }

        public MiPageHash(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPageHash>();
        }
    }
}