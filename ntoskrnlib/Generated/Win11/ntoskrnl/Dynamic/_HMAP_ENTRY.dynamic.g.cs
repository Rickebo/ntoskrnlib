using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HMAP_ENTRY")]
    public sealed class _HMAP_ENTRY : DynamicStructure
    {
        public ulong BlockOffset { get; }
        public ulong PermanentBinAddress { get; }
        public uint MemAlloc { get; }

        public _HMAP_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HMAP_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HMAP_ENTRY.BlockOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HMAP_ENTRY.PermanentBinAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HMAP_ENTRY.MemAlloc),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HMAP_ENTRY>((mem, ptr) => new _HMAP_ENTRY(mem, ptr), offsets);
        }
    }
}