using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_INTERNAL_BREAKPOINT64")]
    public sealed class DbgkdSetInternalBREAKPOINT64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BreakpointAddress { get => ReadHere<ulong>(nameof(BreakpointAddress)); set => WriteHere(nameof(BreakpointAddress), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public DbgkdSetInternalBREAKPOINT64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdSetInternalBREAKPOINT64>();
        }
    }
}