using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTLP_HP_METADATA_HEAP_CTX")]
    public sealed class RtlpHpMetadataHeapCtx : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Heap { get => ReadHere<IntPtr>(nameof(Heap)); set => WriteHere(nameof(Heap), value); }

        [Offset(8UL)]
        public RtlRunOnce InitOnce { get => ReadStructure<RtlRunOnce>(nameof(InitOnce)); set => WriteStructure(nameof(InitOnce), value); }

        public RtlpHpMetadataHeapCtx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHpMetadataHeapCtx>();
        }
    }
}