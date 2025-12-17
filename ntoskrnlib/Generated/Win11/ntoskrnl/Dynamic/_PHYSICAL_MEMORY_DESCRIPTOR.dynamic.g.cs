using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PHYSICAL_MEMORY_DESCRIPTOR")]
    public sealed class _PHYSICAL_MEMORY_DESCRIPTOR : DynamicStructure
    {
        public uint NumberOfRuns { get; }
        public ulong NumberOfPages { get; }
        public byte[] Run { get; }

        public _PHYSICAL_MEMORY_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PHYSICAL_MEMORY_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PHYSICAL_MEMORY_DESCRIPTOR.NumberOfRuns),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PHYSICAL_MEMORY_DESCRIPTOR.NumberOfPages),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PHYSICAL_MEMORY_DESCRIPTOR.Run),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PHYSICAL_MEMORY_DESCRIPTOR>((mem, ptr) => new _PHYSICAL_MEMORY_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}