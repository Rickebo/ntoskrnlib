using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_SLOT_MAP")]
    public sealed class _HEAP_LFH_SLOT_MAP : DynamicStructure
    {
        public ushort[] Map { get; }

        public _HEAP_LFH_SLOT_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_SLOT_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_SLOT_MAP.Map),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_SLOT_MAP>((mem, ptr) => new _HEAP_LFH_SLOT_MAP(mem, ptr), offsets);
        }
    }
}