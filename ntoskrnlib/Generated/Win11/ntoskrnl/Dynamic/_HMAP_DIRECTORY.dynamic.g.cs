using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HMAP_DIRECTORY")]
    public sealed class _HMAP_DIRECTORY : DynamicStructure
    {
        public byte[] Directory { get; }

        public _HMAP_DIRECTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HMAP_DIRECTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HMAP_DIRECTORY.Directory),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HMAP_DIRECTORY>((mem, ptr) => new _HMAP_DIRECTORY(mem, ptr), offsets);
        }
    }
}