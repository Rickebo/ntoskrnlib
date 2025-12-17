using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_EMERGENCY_LA_QUEUE_ENTRY")]
    public sealed class _HALP_EMERGENCY_LA_QUEUE_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint EntryType { get; }

        public _HALP_EMERGENCY_LA_QUEUE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_EMERGENCY_LA_QUEUE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_EMERGENCY_LA_QUEUE_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_EMERGENCY_LA_QUEUE_ENTRY.EntryType),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HALP_EMERGENCY_LA_QUEUE_ENTRY>((mem, ptr) => new _HALP_EMERGENCY_LA_QUEUE_ENTRY(mem, ptr), offsets);
        }
    }
}