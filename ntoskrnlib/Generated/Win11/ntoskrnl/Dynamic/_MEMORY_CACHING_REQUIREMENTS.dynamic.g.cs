using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MEMORY_CACHING_REQUIREMENTS")]
    public sealed class _MEMORY_CACHING_REQUIREMENTS : DynamicStructure
    {
        public ulong BasePage { get; }
        public ulong PageCount { get; }
        public uint MemoryCachingType { get; }

        public _MEMORY_CACHING_REQUIREMENTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MEMORY_CACHING_REQUIREMENTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MEMORY_CACHING_REQUIREMENTS.BasePage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MEMORY_CACHING_REQUIREMENTS.PageCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MEMORY_CACHING_REQUIREMENTS.MemoryCachingType),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MEMORY_CACHING_REQUIREMENTS>((mem, ptr) => new _MEMORY_CACHING_REQUIREMENTS(mem, ptr), offsets);
        }
    }
}