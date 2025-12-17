using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS")]
    public sealed class WheaXpfProcessorErrorSectionValidbits : DynamicStructure
    {
        [Offset(0UL)]
        public ulong LocalAPICId { get => ReadHere<ulong>(nameof(LocalAPICId)); set => WriteHere(nameof(LocalAPICId), value); }

        [Offset(0UL)]
        public ulong CpuId { get => ReadHere<ulong>(nameof(CpuId)); set => WriteHere(nameof(CpuId), value); }

        [Offset(0UL)]
        public ulong ProcInfoCount { get => ReadHere<ulong>(nameof(ProcInfoCount)); set => WriteHere(nameof(ProcInfoCount), value); }

        [Offset(0UL)]
        public ulong ContextInfoCount { get => ReadHere<ulong>(nameof(ContextInfoCount)); set => WriteHere(nameof(ContextInfoCount), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong ValidBits { get => ReadHere<ulong>(nameof(ValidBits)); set => WriteHere(nameof(ValidBits), value); }

        public WheaXpfProcessorErrorSectionValidbits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaXpfProcessorErrorSectionValidbits>();
        }
    }
}