using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARM64_DBGKD_CONTROL_SET")]
    public sealed class _ARM64_DBGKD_CONTROL_SET : DynamicStructure
    {
        public uint Continue { get; }
        public uint TraceFlag { get; }
        public ulong CurrentSymbolStart { get; }
        public ulong CurrentSymbolEnd { get; }

        public _ARM64_DBGKD_CONTROL_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARM64_DBGKD_CONTROL_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARM64_DBGKD_CONTROL_SET.Continue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_DBGKD_CONTROL_SET.TraceFlag),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ARM64_DBGKD_CONTROL_SET.CurrentSymbolStart),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARM64_DBGKD_CONTROL_SET.CurrentSymbolEnd),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_ARM64_DBGKD_CONTROL_SET>((mem, ptr) => new _ARM64_DBGKD_CONTROL_SET(mem, ptr), offsets);
        }
    }
}