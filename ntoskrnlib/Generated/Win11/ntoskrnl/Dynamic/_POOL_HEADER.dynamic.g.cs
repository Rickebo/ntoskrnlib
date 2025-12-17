using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POOL_HEADER")]
    public sealed class _POOL_HEADER : DynamicStructure
    {
        public ushort PreviousSize { get; }
        public ushort PoolIndex { get; }
        public ushort BlockSize { get; }
        public ushort PoolType { get; }
        public uint Ulong1 { get; }
        public uint PoolTag { get; }
        public IntPtr ProcessBilled { get; }
        public ushort AllocatorBackTraceIndex { get; }
        public ushort PoolTagHash { get; }

        public _POOL_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POOL_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POOL_HEADER.PreviousSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_HEADER.PoolIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_HEADER.BlockSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_POOL_HEADER.PoolType),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_POOL_HEADER.Ulong1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_HEADER.PoolTag),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POOL_HEADER.ProcessBilled),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POOL_HEADER.AllocatorBackTraceIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POOL_HEADER.PoolTagHash),
                    new ulong[]
                    {
                        10UL
                    }
                }
            };
            Register<_POOL_HEADER>((mem, ptr) => new _POOL_HEADER(mem, ptr), offsets);
        }
    }
}