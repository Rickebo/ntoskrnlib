using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_PLATFORM_STATE_RESIDENCY")]
    public sealed class ProcessorPlatformStateResidency : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Residency { get => ReadHere<ulong>(nameof(Residency)); set => WriteHere(nameof(Residency), value); }

        [Offset(8UL)]
        public ulong TransitionCount { get => ReadHere<ulong>(nameof(TransitionCount)); set => WriteHere(nameof(TransitionCount), value); }

        public ProcessorPlatformStateResidency(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorPlatformStateResidency>();
        }
    }
}