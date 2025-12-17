using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_MEMORY_RANGE")]
    public sealed class _LOADER_MEMORY_RANGE : DynamicStructure
    {
        public ulong StartPage { get; }
        public ulong NumberOfPages { get; }

        public _LOADER_MEMORY_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_MEMORY_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_MEMORY_RANGE.StartPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_MEMORY_RANGE.NumberOfPages),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_LOADER_MEMORY_RANGE>((mem, ptr) => new _LOADER_MEMORY_RANGE(mem, ptr), offsets);
        }
    }
}