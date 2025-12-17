using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IA64_DBGKD_CONTROL_SET")]
    public sealed class _IA64_DBGKD_CONTROL_SET : DynamicStructure
    {
        public uint Continue { get; }
        public ulong CurrentSymbolStart { get; }
        public ulong CurrentSymbolEnd { get; }

        public _IA64_DBGKD_CONTROL_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IA64_DBGKD_CONTROL_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IA64_DBGKD_CONTROL_SET.Continue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IA64_DBGKD_CONTROL_SET.CurrentSymbolStart),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IA64_DBGKD_CONTROL_SET.CurrentSymbolEnd),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_IA64_DBGKD_CONTROL_SET>((mem, ptr) => new _IA64_DBGKD_CONTROL_SET(mem, ptr), offsets);
        }
    }
}