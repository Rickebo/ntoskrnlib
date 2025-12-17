using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HMAP_TABLE")]
    public sealed class _HMAP_TABLE : DynamicStructure
    {
        public byte[] Table { get; }

        public _HMAP_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HMAP_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HMAP_TABLE.Table),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HMAP_TABLE>((mem, ptr) => new _HMAP_TABLE(mem, ptr), offsets);
        }
    }
}