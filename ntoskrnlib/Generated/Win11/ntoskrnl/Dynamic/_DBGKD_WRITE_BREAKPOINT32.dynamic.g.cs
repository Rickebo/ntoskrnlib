using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_WRITE_BREAKPOINT32")]
    public sealed class _DBGKD_WRITE_BREAKPOINT32 : DynamicStructure
    {
        public uint BreakPointAddress { get; }
        public uint BreakPointHandle { get; }

        public _DBGKD_WRITE_BREAKPOINT32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_WRITE_BREAKPOINT32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_WRITE_BREAKPOINT32.BreakPointAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_WRITE_BREAKPOINT32.BreakPointHandle),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_DBGKD_WRITE_BREAKPOINT32>((mem, ptr) => new _DBGKD_WRITE_BREAKPOINT32(mem, ptr), offsets);
        }
    }
}