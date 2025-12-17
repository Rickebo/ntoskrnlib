using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VAMGR_CTX")]
    public sealed class _HEAP_VAMGR_CTX : DynamicStructure
    {
        public _HEAP_VAMGR_VASPACE VaSpace { get; }
        public ulong AllocatorLock { get; }
        public uint DefaultRegionSize { get; }
        public uint AllocatorCount { get; }
        public byte[] Allocators { get; }

        public _HEAP_VAMGR_CTX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VAMGR_CTX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VAMGR_CTX.VaSpace),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_CTX.AllocatorLock),
                    new ulong[]
                    {
                        2144UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_CTX.DefaultRegionSize),
                    new ulong[]
                    {
                        2152UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_CTX.AllocatorCount),
                    new ulong[]
                    {
                        2156UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_CTX.Allocators),
                    new ulong[]
                    {
                        2160UL
                    }
                }
            };
            Register<_HEAP_VAMGR_CTX>((mem, ptr) => new _HEAP_VAMGR_CTX(mem, ptr), offsets);
        }
    }
}