using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_POOL_STATE")]
    public sealed class _MI_POOL_STATE : DynamicStructure
    {
        public ulong MaximumNonPagedPoolThreshold { get; }
        public ulong AllocatedNonPagedPool { get; }
        public ulong AllocatedSecureNonPagedPool { get; }
        public uint HighEventSets { get; }
        public byte HighEventSetsValid { get; }
        public ulong LowPagedPoolThreshold { get; }
        public ulong HighPagedPoolThreshold { get; }
        public int PermittedFaultsLock { get; }
        public _RTL_AVL_TREE PermittedFaultsTree { get; }
        public byte[] PermittedFaultsInitialNode { get; }
        public ulong TotalPagedPoolQuota { get; }
        public ulong TotalNonPagedPoolQuota { get; }
        public byte[] PagedPoolWorkingSetLockArray { get; }

        public _MI_POOL_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_POOL_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_POOL_STATE.MaximumNonPagedPoolThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.AllocatedNonPagedPool),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.AllocatedSecureNonPagedPool),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.HighEventSets),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.HighEventSetsValid),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.LowPagedPoolThreshold),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.HighPagedPoolThreshold),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.PermittedFaultsLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.PermittedFaultsTree),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.PermittedFaultsInitialNode),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.TotalPagedPoolQuota),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.TotalNonPagedPoolQuota),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_POOL_STATE.PagedPoolWorkingSetLockArray),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_MI_POOL_STATE>((mem, ptr) => new _MI_POOL_STATE(mem, ptr), offsets);
        }
    }
}