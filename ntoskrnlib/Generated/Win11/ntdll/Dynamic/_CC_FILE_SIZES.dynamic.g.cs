using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_CC_FILE_SIZES")]
    public sealed class _CC_FILE_SIZES : DynamicStructure
    {
        public _LARGE_INTEGER AllocationSize { get; }
        public _LARGE_INTEGER FileSize { get; }
        public _LARGE_INTEGER ValidDataLength { get; }

        public _CC_FILE_SIZES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CC_FILE_SIZES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CC_FILE_SIZES.AllocationSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CC_FILE_SIZES.FileSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CC_FILE_SIZES.ValidDataLength),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_CC_FILE_SIZES>((mem, ptr) => new _CC_FILE_SIZES(mem, ptr), offsets);
        }
    }
}