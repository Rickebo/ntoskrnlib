using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_CACHED_PTES")]
    public sealed class _MI_CACHED_PTES : DynamicStructure
    {
        public byte[] Bins { get; }
        public long CachedPteCount { get; }

        public _MI_CACHED_PTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_CACHED_PTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_CACHED_PTES.Bins),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CACHED_PTES.CachedPteCount),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MI_CACHED_PTES>((mem, ptr) => new _MI_CACHED_PTES(mem, ptr), offsets);
        }
    }
}