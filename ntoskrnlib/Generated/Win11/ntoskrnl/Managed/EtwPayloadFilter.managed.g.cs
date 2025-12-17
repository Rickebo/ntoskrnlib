using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_PAYLOAD_FILTER")]
    public sealed class EtwPayloadFilter : DynamicStructure
    {
        [Offset(0UL)]
        public int RefCount { get => ReadHere<int>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(8UL)]
        public AggregatedPayloadFilter PayloadFilter { get => ReadStructure<AggregatedPayloadFilter>(nameof(PayloadFilter)); set => WriteStructure(nameof(PayloadFilter), value); }

        public EtwPayloadFilter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwPayloadFilter>();
        }
    }
}