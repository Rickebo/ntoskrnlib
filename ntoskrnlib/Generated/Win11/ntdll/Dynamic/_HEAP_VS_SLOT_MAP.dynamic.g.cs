using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VS_SLOT_MAP")]
    public sealed class _HEAP_VS_SLOT_MAP : DynamicStructure
    {
        public ushort SlotRef { get; }
        public ushort ContentionRemapCount { get; }

        public _HEAP_VS_SLOT_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_SLOT_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_SLOT_MAP.SlotRef),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_SLOT_MAP.ContentionRemapCount),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_HEAP_VS_SLOT_MAP>((mem, ptr) => new _HEAP_VS_SLOT_MAP(mem, ptr), offsets);
        }
    }
}