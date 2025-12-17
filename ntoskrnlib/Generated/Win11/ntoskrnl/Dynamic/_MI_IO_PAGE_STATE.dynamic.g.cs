using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_IO_PAGE_STATE")]
    public sealed class _MI_IO_PAGE_STATE : DynamicStructure
    {
        public byte[] TypeCell { get; }
        public _RTL_AVL_TREE InvariantIoSpace { get; }
        public _RTL_AVL_TREE ExclusionSpace { get; }
        public int IoPfnPruneLock { get; }
        public _WORK_QUEUE_ITEM UnmappedNodeWorkItem { get; }
        public _MI_IO_CACHE_STATS IoCacheStats { get; }

        public _MI_IO_PAGE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_IO_PAGE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_IO_PAGE_STATE.TypeCell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE.InvariantIoSpace),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE.ExclusionSpace),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE.IoPfnPruneLock),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE.UnmappedNodeWorkItem),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE.IoCacheStats),
                    new ulong[]
                    {
                        184UL
                    }
                }
            };
            Register<_MI_IO_PAGE_STATE>((mem, ptr) => new _MI_IO_PAGE_STATE(mem, ptr), offsets);
        }
    }
}