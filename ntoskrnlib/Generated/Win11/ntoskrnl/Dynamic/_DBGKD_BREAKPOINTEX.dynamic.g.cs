using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_BREAKPOINTEX")]
    public sealed class _DBGKD_BREAKPOINTEX : DynamicStructure
    {
        public uint BreakPointCount { get; }
        public int ContinueStatus { get; }

        public _DBGKD_BREAKPOINTEX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_BREAKPOINTEX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_BREAKPOINTEX.BreakPointCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_BREAKPOINTEX.ContinueStatus),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_DBGKD_BREAKPOINTEX>((mem, ptr) => new _DBGKD_BREAKPOINTEX(mem, ptr), offsets);
        }
    }
}