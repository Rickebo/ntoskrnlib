using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_PLATFORM_STATE_RESIDENCIES")]
    public sealed class ProcessorPlatformStateResidencies : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray States { get => ReadStructure<DynamicArray>(nameof(States)); set => WriteStructure(nameof(States), value); }

        public ProcessorPlatformStateResidencies(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorPlatformStateResidencies>();
        }
    }
}