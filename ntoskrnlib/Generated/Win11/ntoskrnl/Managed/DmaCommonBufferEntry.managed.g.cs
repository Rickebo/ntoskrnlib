using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_COMMON_BUFFER_ENTRY")]
    public sealed class DmaCommonBufferEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr VirtualAddress { get => ReadHere<IntPtr>(nameof(VirtualAddress)); set => WriteHere(nameof(VirtualAddress), value); }

        [Offset(8UL)]
        public LargeInteger LogicalAddress { get => ReadStructure<LargeInteger>(nameof(LogicalAddress)); set => WriteStructure(nameof(LogicalAddress), value); }

        public DmaCommonBufferEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaCommonBufferEntry>();
        }
    }
}