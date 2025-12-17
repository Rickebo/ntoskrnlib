using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_PTRREF_LIST")]
    public sealed class _HEAP_LFH_PTRREF_LIST : DynamicStructure
    {
        public ushort Flink { get; }
        public ushort Blink { get; }

        public _HEAP_LFH_PTRREF_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_PTRREF_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_PTRREF_LIST.Flink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_PTRREF_LIST.Blink),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_HEAP_LFH_PTRREF_LIST>((mem, ptr) => new _HEAP_LFH_PTRREF_LIST(mem, ptr), offsets);
        }
    }
}