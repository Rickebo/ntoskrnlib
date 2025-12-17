using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAKE_HEAP_ENTRY")]
    public sealed class _FAKE_HEAP_ENTRY : DynamicStructure
    {
        public ulong Size { get; }
        public ulong PreviousSize { get; }

        public _FAKE_HEAP_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAKE_HEAP_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAKE_HEAP_ENTRY.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAKE_HEAP_ENTRY.PreviousSize),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_FAKE_HEAP_ENTRY>((mem, ptr) => new _FAKE_HEAP_ENTRY(mem, ptr), offsets);
        }
    }
}