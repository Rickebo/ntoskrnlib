using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_CACHED_PTE")]
    public sealed class _MI_CACHED_PTE : DynamicStructure
    {
        public ulong GlobalTimeStamp { get; }
        public ulong PteIndex { get; }
        public ulong Long { get; }

        public _MI_CACHED_PTE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_CACHED_PTE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_CACHED_PTE.GlobalTimeStamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CACHED_PTE.PteIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CACHED_PTE.Long),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_CACHED_PTE>((mem, ptr) => new _MI_CACHED_PTE(mem, ptr), offsets);
        }
    }
}