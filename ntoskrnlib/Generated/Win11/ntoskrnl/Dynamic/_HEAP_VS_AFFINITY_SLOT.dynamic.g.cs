using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_VS_AFFINITY_SLOT")]
    public sealed class _HEAP_VS_AFFINITY_SLOT : DynamicStructure
    {
        public IntPtr VsContext { get; }
        public ulong Lock { get; }
        public _RTL_RB_TREE FreeChunkTree { get; }
        public _LIST_ENTRY SubsegmentList { get; }
        public _HEAP_VS_DELAY_FREE_CONTEXT DelayFreeContext { get; }

        public _HEAP_VS_AFFINITY_SLOT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_AFFINITY_SLOT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_AFFINITY_SLOT.VsContext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_AFFINITY_SLOT.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VS_AFFINITY_SLOT.FreeChunkTree),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_VS_AFFINITY_SLOT.SubsegmentList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_VS_AFFINITY_SLOT.DelayFreeContext),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_HEAP_VS_AFFINITY_SLOT>((mem, ptr) => new _HEAP_VS_AFFINITY_SLOT(mem, ptr), offsets);
        }
    }
}