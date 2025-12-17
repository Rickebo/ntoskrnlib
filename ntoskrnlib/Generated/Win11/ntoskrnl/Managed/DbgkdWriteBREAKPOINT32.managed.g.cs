using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_WRITE_BREAKPOINT32")]
    public sealed class DbgkdWriteBREAKPOINT32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint BreakPointAddress { get => ReadHere<uint>(nameof(BreakPointAddress)); set => WriteHere(nameof(BreakPointAddress), value); }

        [Offset(4UL)]
        public uint BreakPointHandle { get => ReadHere<uint>(nameof(BreakPointHandle)); set => WriteHere(nameof(BreakPointHandle), value); }

        public DbgkdWriteBREAKPOINT32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdWriteBREAKPOINT32>();
        }
    }
}