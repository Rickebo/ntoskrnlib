using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT_STATE")]
    public sealed class _HEAP_LFH_SUBSEGMENT_STATE : DynamicStructure
    {
        public ushort DelayFreeList { get; }
        public ushort DelayFreeCount { get; }
        public ushort Owner { get; }
        public byte Location { get; }
        public int DelayFreeFields { get; }
        public int OwnerLocation { get; }
        public _HEAP_LFH_BLOCK_LIST FreeList { get; }
        public IntPtr AllBits { get; }

        public _HEAP_LFH_SUBSEGMENT_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_SUBSEGMENT_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.DelayFreeList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.DelayFreeCount),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.Owner),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.Location),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.DelayFreeFields),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.OwnerLocation),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.FreeList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_STATE.AllBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_SUBSEGMENT_STATE>((mem, ptr) => new _HEAP_LFH_SUBSEGMENT_STATE(mem, ptr), offsets);
        }
    }
}