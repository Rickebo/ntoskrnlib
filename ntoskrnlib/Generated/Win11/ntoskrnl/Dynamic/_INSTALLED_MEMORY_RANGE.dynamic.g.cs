using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INSTALLED_MEMORY_RANGE")]
    public sealed class _INSTALLED_MEMORY_RANGE : DynamicStructure
    {
        public ulong BasePage { get; }
        public ulong PageCount { get; }

        public _INSTALLED_MEMORY_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INSTALLED_MEMORY_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INSTALLED_MEMORY_RANGE.BasePage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INSTALLED_MEMORY_RANGE.PageCount),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_INSTALLED_MEMORY_RANGE>((mem, ptr) => new _INSTALLED_MEMORY_RANGE(mem, ptr), offsets);
        }
    }
}