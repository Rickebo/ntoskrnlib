using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PHYSICAL_MEMORY_RANGE")]
    public sealed class _PHYSICAL_MEMORY_RANGE : DynamicStructure
    {
        public _LARGE_INTEGER BaseAddress { get; }
        public _LARGE_INTEGER NumberOfBytes { get; }

        public _PHYSICAL_MEMORY_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PHYSICAL_MEMORY_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PHYSICAL_MEMORY_RANGE.BaseAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PHYSICAL_MEMORY_RANGE.NumberOfBytes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PHYSICAL_MEMORY_RANGE>((mem, ptr) => new _PHYSICAL_MEMORY_RANGE(mem, ptr), offsets);
        }
    }
}