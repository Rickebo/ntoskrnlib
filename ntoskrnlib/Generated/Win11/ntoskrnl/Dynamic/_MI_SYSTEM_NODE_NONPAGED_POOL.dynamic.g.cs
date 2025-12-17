using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_NODE_NONPAGED_POOL")]
    public sealed class _MI_SYSTEM_NODE_NONPAGED_POOL : DynamicStructure
    {
        public _MI_DYNAMIC_BITMAP DynamicBitMapNonPagedPool { get; }
        public int NonPagedPoolSpinLock { get; }
        public _MI_PAGE_CHAIN_HEAD CachedNonPagedPool { get; }
        public IntPtr NonPagedPoolFirstVa { get; }
        public IntPtr NonPagedPoolLastVa { get; }
        public byte[] OptimalZeroingAttribute { get; }
        public byte[] ZeroCostCounts { get; }
        public IntPtr SystemNodeInformation { get; }

        public _MI_SYSTEM_NODE_NONPAGED_POOL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_NODE_NONPAGED_POOL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.DynamicBitMapNonPagedPool),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.NonPagedPoolSpinLock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.CachedNonPagedPool),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.NonPagedPoolFirstVa),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.NonPagedPoolLastVa),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.OptimalZeroingAttribute),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.ZeroCostCounts),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_NONPAGED_POOL.SystemNodeInformation),
                    new ulong[]
                    {
                        376UL
                    }
                }
            };
            Register<_MI_SYSTEM_NODE_NONPAGED_POOL>((mem, ptr) => new _MI_SYSTEM_NODE_NONPAGED_POOL(mem, ptr), offsets);
        }
    }
}