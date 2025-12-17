using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_POOL_HEAP_MANAGER_STATE")]
    public sealed class _EX_POOL_HEAP_MANAGER_STATE : DynamicStructure
    {
        public _RTLP_HP_HEAP_MANAGER HeapManager { get; }
        public _EX_PUSH_LOCK PrivatePoolListLock { get; }
        public byte[] PrivatePools { get; }
        public ulong PrivatePoolContextCookie { get; }
        public uint NumberOfPools { get; }
        public byte[] PoolNode { get; }
        public byte[] SpecialHeaps { get; }

        public _EX_POOL_HEAP_MANAGER_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_POOL_HEAP_MANAGER_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_POOL_HEAP_MANAGER_STATE.HeapManager),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_POOL_HEAP_MANAGER_STATE.PrivatePoolListLock),
                    new ulong[]
                    {
                        14560UL
                    }
                },
                {
                    nameof(_EX_POOL_HEAP_MANAGER_STATE.PrivatePools),
                    new ulong[]
                    {
                        14568UL
                    }
                },
                {
                    nameof(_EX_POOL_HEAP_MANAGER_STATE.PrivatePoolContextCookie),
                    new ulong[]
                    {
                        14600UL
                    }
                },
                {
                    nameof(_EX_POOL_HEAP_MANAGER_STATE.NumberOfPools),
                    new ulong[]
                    {
                        14608UL
                    }
                },
                {
                    nameof(_EX_POOL_HEAP_MANAGER_STATE.PoolNode),
                    new ulong[]
                    {
                        14656UL
                    }
                },
                {
                    nameof(_EX_POOL_HEAP_MANAGER_STATE.SpecialHeaps),
                    new ulong[]
                    {
                        551232UL
                    }
                }
            };
            Register<_EX_POOL_HEAP_MANAGER_STATE>((mem, ptr) => new _EX_POOL_HEAP_MANAGER_STATE(mem, ptr), offsets);
        }
    }
}