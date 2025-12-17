using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_BAD_MEMORY_EVENT_ENTRY")]
    public sealed class _MI_BAD_MEMORY_EVENT_ENTRY : DynamicStructure
    {
        public uint BugCheckCode { get; }
        public int Active { get; }
        public uint Data { get; }
        public _LARGE_INTEGER PhysicalAddress { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }

        public _MI_BAD_MEMORY_EVENT_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_BAD_MEMORY_EVENT_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_BAD_MEMORY_EVENT_ENTRY.BugCheckCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_BAD_MEMORY_EVENT_ENTRY.Active),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_BAD_MEMORY_EVENT_ENTRY.Data),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_BAD_MEMORY_EVENT_ENTRY.PhysicalAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_BAD_MEMORY_EVENT_ENTRY.WorkItem),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_BAD_MEMORY_EVENT_ENTRY>((mem, ptr) => new _MI_BAD_MEMORY_EVENT_ENTRY(mem, ptr), offsets);
        }
    }
}