using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_CONFIG")]
    public sealed class _HEAP_LFH_CONFIG : DynamicStructure
    {
        public _RTL_HP_LFH_CONFIG Global { get; }
        public uint EnablePrivateSlots { get; }

        public _HEAP_LFH_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_CONFIG.Global),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONFIG.EnablePrivateSlots),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_HEAP_LFH_CONFIG>((mem, ptr) => new _HEAP_LFH_CONFIG(mem, ptr), offsets);
        }
    }
}