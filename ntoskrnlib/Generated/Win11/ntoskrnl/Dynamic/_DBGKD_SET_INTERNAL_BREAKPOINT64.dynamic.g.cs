using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_INTERNAL_BREAKPOINT64")]
    public sealed class _DBGKD_SET_INTERNAL_BREAKPOINT64 : DynamicStructure
    {
        public ulong BreakpointAddress { get; }
        public uint Flags { get; }

        public _DBGKD_SET_INTERNAL_BREAKPOINT64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_SET_INTERNAL_BREAKPOINT64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_SET_INTERNAL_BREAKPOINT64.BreakpointAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_SET_INTERNAL_BREAKPOINT64.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DBGKD_SET_INTERNAL_BREAKPOINT64>((mem, ptr) => new _DBGKD_SET_INTERNAL_BREAKPOINT64(mem, ptr), offsets);
        }
    }
}