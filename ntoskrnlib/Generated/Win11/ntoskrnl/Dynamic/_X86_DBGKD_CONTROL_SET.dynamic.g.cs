using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_X86_DBGKD_CONTROL_SET")]
    public sealed class _X86_DBGKD_CONTROL_SET : DynamicStructure
    {
        public uint TraceFlag { get; }
        public uint Dr7 { get; }
        public uint CurrentSymbolStart { get; }
        public uint CurrentSymbolEnd { get; }

        public _X86_DBGKD_CONTROL_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _X86_DBGKD_CONTROL_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_X86_DBGKD_CONTROL_SET.TraceFlag),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_X86_DBGKD_CONTROL_SET.Dr7),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_X86_DBGKD_CONTROL_SET.CurrentSymbolStart),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_X86_DBGKD_CONTROL_SET.CurrentSymbolEnd),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_X86_DBGKD_CONTROL_SET>((mem, ptr) => new _X86_DBGKD_CONTROL_SET(mem, ptr), offsets);
        }
    }
}