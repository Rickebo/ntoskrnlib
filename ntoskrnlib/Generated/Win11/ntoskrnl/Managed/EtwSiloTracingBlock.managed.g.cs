using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_SILO_TRACING_BLOCK")]
    public sealed class EtwSiloTracingBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ProcessorBuffers { get => ReadHere<IntPtr>(nameof(ProcessorBuffers)); set => WriteHere(nameof(ProcessorBuffers), value); }

        [Offset(8UL)]
        public IntPtr EventsLoggedCount { get => ReadHere<IntPtr>(nameof(EventsLoggedCount)); set => WriteHere(nameof(EventsLoggedCount), value); }

        [Offset(16UL)]
        public IntPtr QpcDelta { get => ReadHere<IntPtr>(nameof(QpcDelta)); set => WriteHere(nameof(QpcDelta), value); }

        public EtwSiloTracingBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSiloTracingBlock>();
        }
    }
}