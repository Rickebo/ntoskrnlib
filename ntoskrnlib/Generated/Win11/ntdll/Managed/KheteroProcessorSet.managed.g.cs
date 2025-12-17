using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KHETERO_PROCESSOR_SET")]
    public sealed class KheteroProcessorSet : DynamicStructure
    {
        [Offset(0UL)]
        public ulong IdealMask { get => ReadHere<ulong>(nameof(IdealMask)); set => WriteHere(nameof(IdealMask), value); }

        [Offset(8UL)]
        public ulong PreferredMask { get => ReadHere<ulong>(nameof(PreferredMask)); set => WriteHere(nameof(PreferredMask), value); }

        [Offset(16UL)]
        public ulong AvailableMask { get => ReadHere<ulong>(nameof(AvailableMask)); set => WriteHere(nameof(AvailableMask), value); }

        public KheteroProcessorSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KheteroProcessorSet>();
        }
    }
}