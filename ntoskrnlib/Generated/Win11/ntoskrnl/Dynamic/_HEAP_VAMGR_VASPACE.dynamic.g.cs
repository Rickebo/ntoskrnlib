using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_VAMGR_VASPACE")]
    public sealed class _HEAP_VAMGR_VASPACE : DynamicStructure
    {
        public uint AddressSpaceType { get; }
        public ulong BaseAddress { get; }
        public _RTL_SPARSE_ARRAY VaRangeArray { get; }
        public byte[] VaRangeArrayBuffer { get; }

        public _HEAP_VAMGR_VASPACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VAMGR_VASPACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VAMGR_VASPACE.AddressSpaceType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_VASPACE.BaseAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_VASPACE.VaRangeArray),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_VASPACE.VaRangeArrayBuffer),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HEAP_VAMGR_VASPACE>((mem, ptr) => new _HEAP_VAMGR_VASPACE(mem, ptr), offsets);
        }
    }
}