using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VAMGR_ALLOCATOR")]
    public sealed class _HEAP_VAMGR_ALLOCATOR : DynamicStructure
    {
        public ulong TreeLock { get; }
        public _RTL_RB_TREE FreeRanges { get; }
        public IntPtr VaSpace { get; }
        public IntPtr ContextHandle { get; }
        public ushort ChunksPerRegion { get; }
        public ushort RefCount { get; }
        public byte AllocatorIndex { get; }
        public byte NumaNode { get; }
        public byte LockType { get; }
        public byte MemoryType { get; }
        public byte ConstrainedVA { get; }
        public byte AllowFreeHead { get; }
        public byte Spare0 { get; }
        public byte Spare1 { get; }

        public _HEAP_VAMGR_ALLOCATOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VAMGR_ALLOCATOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.TreeLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.FreeRanges),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.VaSpace),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.ContextHandle),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.ChunksPerRegion),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.RefCount),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.AllocatorIndex),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.NumaNode),
                    new ulong[]
                    {
                        45UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.LockType),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.MemoryType),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.ConstrainedVA),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.AllowFreeHead),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.Spare0),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_ALLOCATOR.Spare1),
                    new ulong[]
                    {
                        47UL
                    }
                }
            };
            Register<_HEAP_VAMGR_ALLOCATOR>((mem, ptr) => new _HEAP_VAMGR_ALLOCATOR(mem, ptr), offsets);
        }
    }
}