using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_WRITE_CUSTOM_BREAKPOINT")]
    public sealed class _DBGKD_WRITE_CUSTOM_BREAKPOINT : DynamicStructure
    {
        public ulong BreakPointAddress { get; }
        public ulong BreakPointInstruction { get; }
        public uint BreakPointHandle { get; }
        public byte BreakPointInstructionSize { get; }
        public byte BreakPointInstructionAlignment { get; }

        public _DBGKD_WRITE_CUSTOM_BREAKPOINT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_WRITE_CUSTOM_BREAKPOINT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_WRITE_CUSTOM_BREAKPOINT.BreakPointAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_WRITE_CUSTOM_BREAKPOINT.BreakPointInstruction),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_WRITE_CUSTOM_BREAKPOINT.BreakPointHandle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_WRITE_CUSTOM_BREAKPOINT.BreakPointInstructionSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DBGKD_WRITE_CUSTOM_BREAKPOINT.BreakPointInstructionAlignment),
                    new ulong[]
                    {
                        21UL
                    }
                }
            };
            Register<_DBGKD_WRITE_CUSTOM_BREAKPOINT>((mem, ptr) => new _DBGKD_WRITE_CUSTOM_BREAKPOINT(mem, ptr), offsets);
        }
    }
}