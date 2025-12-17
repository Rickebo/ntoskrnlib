using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPC_DBGKD_CONTROL_SET")]
    public sealed class _PPC_DBGKD_CONTROL_SET : DynamicStructure
    {
        public uint Continue { get; }
        public uint CurrentSymbolStart { get; }
        public uint CurrentSymbolEnd { get; }

        public _PPC_DBGKD_CONTROL_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPC_DBGKD_CONTROL_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPC_DBGKD_CONTROL_SET.Continue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPC_DBGKD_CONTROL_SET.CurrentSymbolStart),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PPC_DBGKD_CONTROL_SET.CurrentSymbolEnd),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PPC_DBGKD_CONTROL_SET>((mem, ptr) => new _PPC_DBGKD_CONTROL_SET(mem, ptr), offsets);
        }
    }
}