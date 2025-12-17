using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_SPARSE_ARRAY")]
    public sealed class _RTL_SPARSE_ARRAY : DynamicStructure
    {
        public ulong ElementCount { get; }
        public uint ElementSizeShift { get; }
        public _RTL_CSPARSE_BITMAP Bitmap { get; }

        public _RTL_SPARSE_ARRAY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_SPARSE_ARRAY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_SPARSE_ARRAY.ElementCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SPARSE_ARRAY.ElementSizeShift),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_SPARSE_ARRAY.Bitmap),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_SPARSE_ARRAY>((mem, ptr) => new _RTL_SPARSE_ARRAY(mem, ptr), offsets);
        }
    }
}