using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_CAPABILITIES")]
    public sealed class ExtIommuCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AsUINT64 { get => ReadHere<ulong>(nameof(AsUINT64)); set => WriteHere(nameof(AsUINT64), value); }

        [Offset(0UL)]
        public ulong GeneratesMsiInterrupts { get => ReadHere<ulong>(nameof(GeneratesMsiInterrupts)); set => WriteHere(nameof(GeneratesMsiInterrupts), value); }

        [Offset(0UL)]
        public ulong CoherentTableWalks { get => ReadHere<ulong>(nameof(CoherentTableWalks)); set => WriteHere(nameof(CoherentTableWalks), value); }

        [Offset(0UL)]
        public ulong InterruptsNotSubjectToRemapping { get => ReadHere<ulong>(nameof(InterruptsNotSubjectToRemapping)); set => WriteHere(nameof(InterruptsNotSubjectToRemapping), value); }

        [Offset(0UL)]
        public ulong InterruptRemapping { get => ReadHere<ulong>(nameof(InterruptRemapping)); set => WriteHere(nameof(InterruptRemapping), value); }

        [Offset(0UL)]
        public ulong Stage2DmaRemapping { get => ReadHere<ulong>(nameof(Stage2DmaRemapping)); set => WriteHere(nameof(Stage2DmaRemapping), value); }

        [Offset(0UL)]
        public ulong Svm { get => ReadHere<ulong>(nameof(Svm)); set => WriteHere(nameof(Svm), value); }

        [Offset(0UL)]
        public ulong PcieFunctionBased { get => ReadHere<ulong>(nameof(PcieFunctionBased)); set => WriteHere(nameof(PcieFunctionBased), value); }

        public ExtIommuCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuCapabilities>();
        }
    }
}