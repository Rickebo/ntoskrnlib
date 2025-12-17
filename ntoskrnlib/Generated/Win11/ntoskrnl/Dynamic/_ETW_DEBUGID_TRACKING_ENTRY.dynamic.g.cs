using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_DEBUGID_TRACKING_ENTRY")]
    public sealed class _ETW_DEBUGID_TRACKING_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public byte ConsumersNotified { get; }
        public byte[] Spare { get; }
        public uint DebugIdSize { get; }
        public _CVDD DebugId { get; }

        public _ETW_DEBUGID_TRACKING_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_DEBUGID_TRACKING_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_DEBUGID_TRACKING_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_DEBUGID_TRACKING_ENTRY.ConsumersNotified),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_DEBUGID_TRACKING_ENTRY.Spare),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_ETW_DEBUGID_TRACKING_ENTRY.DebugIdSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ETW_DEBUGID_TRACKING_ENTRY.DebugId),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ETW_DEBUGID_TRACKING_ENTRY>((mem, ptr) => new _ETW_DEBUGID_TRACKING_ENTRY(mem, ptr), offsets);
        }
    }
}