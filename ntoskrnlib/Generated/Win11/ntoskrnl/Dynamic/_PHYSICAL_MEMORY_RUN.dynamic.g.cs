using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PHYSICAL_MEMORY_RUN")]
    public sealed class _PHYSICAL_MEMORY_RUN : DynamicStructure
    {
        public ulong BasePage { get; }
        public ulong PageCount { get; }

        public _PHYSICAL_MEMORY_RUN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PHYSICAL_MEMORY_RUN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PHYSICAL_MEMORY_RUN.BasePage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PHYSICAL_MEMORY_RUN.PageCount),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PHYSICAL_MEMORY_RUN>((mem, ptr) => new _PHYSICAL_MEMORY_RUN(mem, ptr), offsets);
        }
    }
}