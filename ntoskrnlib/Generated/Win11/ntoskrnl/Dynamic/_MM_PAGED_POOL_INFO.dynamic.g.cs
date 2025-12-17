using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_PAGED_POOL_INFO")]
    public sealed class _MM_PAGED_POOL_INFO : DynamicStructure
    {
        public _EX_PUSH_LOCK Lock { get; }
        public ulong MaximumSize { get; }
        public ulong AllocatedPagedPool { get; }

        public _MM_PAGED_POOL_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_PAGED_POOL_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_PAGED_POOL_INFO.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_PAGED_POOL_INFO.MaximumSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MM_PAGED_POOL_INFO.AllocatedPagedPool),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MM_PAGED_POOL_INFO>((mem, ptr) => new _MM_PAGED_POOL_INFO(mem, ptr), offsets);
        }
    }
}