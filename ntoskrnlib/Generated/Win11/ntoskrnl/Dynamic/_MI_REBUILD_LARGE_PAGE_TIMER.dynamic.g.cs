using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_REBUILD_LARGE_PAGE_TIMER")]
    public sealed class _MI_REBUILD_LARGE_PAGE_TIMER : DynamicStructure
    {
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public byte SecondsLeft { get; }
        public byte RebuildActive { get; }
        public byte NextPassDelta { get; }
        public byte LargeSubPagesActive { get; }

        public _MI_REBUILD_LARGE_PAGE_TIMER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_REBUILD_LARGE_PAGE_TIMER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_REBUILD_LARGE_PAGE_TIMER.WorkItem),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REBUILD_LARGE_PAGE_TIMER.SecondsLeft),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_REBUILD_LARGE_PAGE_TIMER.RebuildActive),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_MI_REBUILD_LARGE_PAGE_TIMER.NextPassDelta),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_MI_REBUILD_LARGE_PAGE_TIMER.LargeSubPagesActive),
                    new ulong[]
                    {
                        35UL
                    }
                }
            };
            Register<_MI_REBUILD_LARGE_PAGE_TIMER>((mem, ptr) => new _MI_REBUILD_LARGE_PAGE_TIMER(mem, ptr), offsets);
        }
    }
}