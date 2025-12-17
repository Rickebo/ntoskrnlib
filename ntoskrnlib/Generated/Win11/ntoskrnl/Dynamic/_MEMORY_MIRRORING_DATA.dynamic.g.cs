using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MEMORY_MIRRORING_DATA")]
    public sealed class _MEMORY_MIRRORING_DATA : DynamicStructure
    {
        public uint MemoryRangeCount { get; }
        public uint IoSpaceRangeCount { get; }
        public IntPtr MemoryRanges { get; }
        public IntPtr IoSpaceRanges { get; }

        public _MEMORY_MIRRORING_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MEMORY_MIRRORING_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MEMORY_MIRRORING_DATA.MemoryRangeCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MEMORY_MIRRORING_DATA.IoSpaceRangeCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MEMORY_MIRRORING_DATA.MemoryRanges),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MEMORY_MIRRORING_DATA.IoSpaceRanges),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MEMORY_MIRRORING_DATA>((mem, ptr) => new _MEMORY_MIRRORING_DATA(mem, ptr), offsets);
        }
    }
}