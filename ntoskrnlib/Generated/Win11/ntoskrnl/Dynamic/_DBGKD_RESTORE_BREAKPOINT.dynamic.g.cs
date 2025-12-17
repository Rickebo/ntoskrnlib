using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_RESTORE_BREAKPOINT")]
    public sealed class _DBGKD_RESTORE_BREAKPOINT : DynamicStructure
    {
        public uint BreakPointHandle { get; }

        public _DBGKD_RESTORE_BREAKPOINT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_RESTORE_BREAKPOINT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_RESTORE_BREAKPOINT.BreakPointHandle),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_RESTORE_BREAKPOINT>((mem, ptr) => new _DBGKD_RESTORE_BREAKPOINT(mem, ptr), offsets);
        }
    }
}