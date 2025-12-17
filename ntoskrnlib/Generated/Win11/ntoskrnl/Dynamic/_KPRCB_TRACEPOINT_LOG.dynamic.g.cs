using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPRCB_TRACEPOINT_LOG")]
    public sealed class _KPRCB_TRACEPOINT_LOG : DynamicStructure
    {
        public byte[] Entries { get; }
        public uint LogIndex { get; }

        public _KPRCB_TRACEPOINT_LOG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB_TRACEPOINT_LOG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCB_TRACEPOINT_LOG.Entries),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_TRACEPOINT_LOG.LogIndex),
                    new ulong[]
                    {
                        8192UL
                    }
                }
            };
            Register<_KPRCB_TRACEPOINT_LOG>((mem, ptr) => new _KPRCB_TRACEPOINT_LOG(mem, ptr), offsets);
        }
    }
}