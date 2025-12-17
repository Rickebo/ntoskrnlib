using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPRCB_TRACEPOINT_LOG_ENTRY")]
    public sealed class _KPRCB_TRACEPOINT_LOG_ENTRY : DynamicStructure
    {
        public ulong OldPc { get; }
        public ulong OldSp { get; }
        public ulong NewPc { get; }
        public ulong NewSp { get; }

        public _KPRCB_TRACEPOINT_LOG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB_TRACEPOINT_LOG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCB_TRACEPOINT_LOG_ENTRY.OldPc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_TRACEPOINT_LOG_ENTRY.OldSp),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KPRCB_TRACEPOINT_LOG_ENTRY.NewPc),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KPRCB_TRACEPOINT_LOG_ENTRY.NewSp),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_KPRCB_TRACEPOINT_LOG_ENTRY>((mem, ptr) => new _KPRCB_TRACEPOINT_LOG_ENTRY(mem, ptr), offsets);
        }
    }
}