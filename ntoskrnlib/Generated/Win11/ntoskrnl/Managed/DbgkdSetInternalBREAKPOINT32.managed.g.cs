using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_INTERNAL_BREAKPOINT32")]
    public sealed class DbgkdSetInternalBREAKPOINT32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint BreakpointAddress { get => ReadHere<uint>(nameof(BreakpointAddress)); set => WriteHere(nameof(BreakpointAddress), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public DbgkdSetInternalBREAKPOINT32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdSetInternalBREAKPOINT32>();
        }
    }
}