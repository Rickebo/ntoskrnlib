using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_FREE_ENTRY_EXTRA")]
    public sealed class _HEAP_FREE_ENTRY_EXTRA : DynamicStructure
    {
        public ushort TagIndex { get; }
        public ushort FreeBackTraceIndex { get; }

        public _HEAP_FREE_ENTRY_EXTRA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_FREE_ENTRY_EXTRA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_FREE_ENTRY_EXTRA.TagIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY_EXTRA.FreeBackTraceIndex),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_HEAP_FREE_ENTRY_EXTRA>((mem, ptr) => new _HEAP_FREE_ENTRY_EXTRA(mem, ptr), offsets);
        }
    }
}