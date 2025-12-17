using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_INTERNAL_BREAKPOINT32")]
    public sealed class _DBGKD_GET_INTERNAL_BREAKPOINT32 : DynamicStructure
    {
        public uint BreakpointAddress { get; }
        public uint Flags { get; }
        public uint Calls { get; }
        public uint MaxCallsPerPeriod { get; }
        public uint MinInstructions { get; }
        public uint MaxInstructions { get; }
        public uint TotalInstructions { get; }

        public _DBGKD_GET_INTERNAL_BREAKPOINT32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_GET_INTERNAL_BREAKPOINT32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT32.BreakpointAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT32.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT32.Calls),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT32.MaxCallsPerPeriod),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT32.MinInstructions),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT32.MaxInstructions),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT32.TotalInstructions),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_DBGKD_GET_INTERNAL_BREAKPOINT32>((mem, ptr) => new _DBGKD_GET_INTERNAL_BREAKPOINT32(mem, ptr), offsets);
        }
    }
}