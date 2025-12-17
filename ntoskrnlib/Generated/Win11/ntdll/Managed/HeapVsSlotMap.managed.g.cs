using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VS_SLOT_MAP")]
    public sealed class HeapVsSlotMap : DynamicStructure
    {
        [Offset(0UL)]
        public ushort SlotRef { get => ReadHere<ushort>(nameof(SlotRef)); set => WriteHere(nameof(SlotRef), value); }

        [Offset(2UL)]
        public ushort ContentionRemapCount { get => ReadHere<ushort>(nameof(ContentionRemapCount)); set => WriteHere(nameof(ContentionRemapCount), value); }

        public HeapVsSlotMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsSlotMap>();
        }
    }
}