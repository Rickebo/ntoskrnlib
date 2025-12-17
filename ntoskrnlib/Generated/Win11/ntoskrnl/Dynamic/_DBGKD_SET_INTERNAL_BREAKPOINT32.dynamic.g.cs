using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_INTERNAL_BREAKPOINT32")]
    public sealed class _DBGKD_SET_INTERNAL_BREAKPOINT32 : DynamicStructure
    {
        public uint BreakpointAddress { get; }
        public uint Flags { get; }

        public _DBGKD_SET_INTERNAL_BREAKPOINT32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_SET_INTERNAL_BREAKPOINT32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_SET_INTERNAL_BREAKPOINT32.BreakpointAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_SET_INTERNAL_BREAKPOINT32.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_DBGKD_SET_INTERNAL_BREAKPOINT32>((mem, ptr) => new _DBGKD_SET_INTERNAL_BREAKPOINT32(mem, ptr), offsets);
        }
    }
}