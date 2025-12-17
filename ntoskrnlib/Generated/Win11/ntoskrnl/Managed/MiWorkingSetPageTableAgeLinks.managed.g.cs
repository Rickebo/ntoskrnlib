using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_WORKING_SET_PAGE_TABLE_AGE_LINKS")]
    public sealed class MiWorkingSetPageTableAgeLinks : DynamicStructure
    {
        [Offset(0UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(4UL)]
        public uint EntryCount { get => ReadHere<uint>(nameof(EntryCount)); set => WriteHere(nameof(EntryCount), value); }

        [Offset(8UL)]
        public IntPtr Flink { get => ReadHere<IntPtr>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(16UL)]
        public IntPtr Blink { get => ReadHere<IntPtr>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        public MiWorkingSetPageTableAgeLinks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiWorkingSetPageTableAgeLinks>();
        }
    }
}