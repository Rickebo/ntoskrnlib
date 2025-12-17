using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTLP_PROCESS_HEAP_DESCRIPTOR")]
    public sealed class RtlpProcessHeapDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry DescriptorLink { get => ReadStructure<ListEntry>(nameof(DescriptorLink)); set => WriteStructure(nameof(DescriptorLink), value); }

        [Offset(16UL)]
        public IntPtr Heap { get => ReadHere<IntPtr>(nameof(Heap)); set => WriteHere(nameof(Heap), value); }

        [Offset(24UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(32UL)]
        public UnnamedTag PseudoGlobalLock { get => ReadStructure<UnnamedTag>(nameof(PseudoGlobalLock)); set => WriteStructure(nameof(PseudoGlobalLock), value); }

        public RtlpProcessHeapDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpProcessHeapDescriptor>();
        }
    }
}