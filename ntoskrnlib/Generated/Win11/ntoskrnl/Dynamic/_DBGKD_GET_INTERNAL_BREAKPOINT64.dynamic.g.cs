using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_INTERNAL_BREAKPOINT64")]
    public sealed class _DBGKD_GET_INTERNAL_BREAKPOINT64 : DynamicStructure
    {
        public ulong BreakpointAddress { get; }
        public uint Flags { get; }
        public uint Calls { get; }
        public uint MaxCallsPerPeriod { get; }
        public uint MinInstructions { get; }
        public uint MaxInstructions { get; }
        public uint TotalInstructions { get; }

        public _DBGKD_GET_INTERNAL_BREAKPOINT64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_GET_INTERNAL_BREAKPOINT64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT64.BreakpointAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT64.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT64.Calls),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT64.MaxCallsPerPeriod),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT64.MinInstructions),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT64.MaxInstructions),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DBGKD_GET_INTERNAL_BREAKPOINT64.TotalInstructions),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_DBGKD_GET_INTERNAL_BREAKPOINT64>((mem, ptr) => new _DBGKD_GET_INTERNAL_BREAKPOINT64(mem, ptr), offsets);
        }
    }
}