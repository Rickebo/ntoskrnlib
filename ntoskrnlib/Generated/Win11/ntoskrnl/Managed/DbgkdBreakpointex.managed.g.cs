using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_BREAKPOINTEX")]
    public sealed class DbgkdBreakpointex : DynamicStructure
    {
        [Offset(0UL)]
        public uint BreakPointCount { get => ReadHere<uint>(nameof(BreakPointCount)); set => WriteHere(nameof(BreakPointCount), value); }

        [Offset(4UL)]
        public int ContinueStatus { get => ReadHere<int>(nameof(ContinueStatus)); set => WriteHere(nameof(ContinueStatus), value); }

        public DbgkdBreakpointex(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdBreakpointex>();
        }
    }
}