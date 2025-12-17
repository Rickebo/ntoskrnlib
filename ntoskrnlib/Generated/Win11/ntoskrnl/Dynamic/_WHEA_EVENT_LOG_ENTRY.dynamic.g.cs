using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_EVENT_LOG_ENTRY")]
    public sealed class _WHEA_EVENT_LOG_ENTRY : DynamicStructure
    {
        public _WHEA_EVENT_LOG_ENTRY_HEADER Header { get; }

        public _WHEA_EVENT_LOG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_EVENT_LOG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY.Header),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_EVENT_LOG_ENTRY>((mem, ptr) => new _WHEA_EVENT_LOG_ENTRY(mem, ptr), offsets);
        }
    }
}