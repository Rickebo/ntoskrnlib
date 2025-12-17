using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AMD64_DBGKD_CONTROL_SET")]
    public sealed class _AMD64_DBGKD_CONTROL_SET : DynamicStructure
    {
        public uint TraceFlag { get; }
        public ulong Dr7 { get; }
        public ulong CurrentSymbolStart { get; }
        public ulong CurrentSymbolEnd { get; }

        public _AMD64_DBGKD_CONTROL_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AMD64_DBGKD_CONTROL_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AMD64_DBGKD_CONTROL_SET.TraceFlag),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_DBGKD_CONTROL_SET.Dr7),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_AMD64_DBGKD_CONTROL_SET.CurrentSymbolStart),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_AMD64_DBGKD_CONTROL_SET.CurrentSymbolEnd),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_AMD64_DBGKD_CONTROL_SET>((mem, ptr) => new _AMD64_DBGKD_CONTROL_SET(mem, ptr), offsets);
        }
    }
}