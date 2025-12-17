using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_RESTORE_BREAKPOINT")]
    public sealed class DbgkdRestoreBreakpoint : DynamicStructure
    {
        [Offset(0UL)]
        public uint BreakPointHandle { get => ReadHere<uint>(nameof(BreakPointHandle)); set => WriteHere(nameof(BreakPointHandle), value); }

        public DbgkdRestoreBreakpoint(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdRestoreBreakpoint>();
        }
    }
}