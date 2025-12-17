using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_WRITE_BREAKPOINT64")]
    public sealed class DbgkdWriteBREAKPOINT64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BreakPointAddress { get => ReadHere<ulong>(nameof(BreakPointAddress)); set => WriteHere(nameof(BreakPointAddress), value); }

        [Offset(8UL)]
        public uint BreakPointHandle { get => ReadHere<uint>(nameof(BreakPointHandle)); set => WriteHere(nameof(BreakPointHandle), value); }

        public DbgkdWriteBREAKPOINT64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdWriteBREAKPOINT64>();
        }
    }
}