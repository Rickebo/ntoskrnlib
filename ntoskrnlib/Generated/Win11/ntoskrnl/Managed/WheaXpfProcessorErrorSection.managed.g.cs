using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_PROCESSOR_ERROR_SECTION")]
    public sealed class WheaXpfProcessorErrorSection : DynamicStructure
    {
        [Offset(0UL)]
        public WheaXpfProcessorErrorSectionValidbits ValidBits { get => ReadStructure<WheaXpfProcessorErrorSectionValidbits>(nameof(ValidBits)); set => WriteStructure(nameof(ValidBits), value); }

        [Offset(8UL)]
        public ulong LocalAPICId { get => ReadHere<ulong>(nameof(LocalAPICId)); set => WriteHere(nameof(LocalAPICId), value); }

        [Offset(16UL)]
        [Length(48)]
        public DynamicArray CpuId { get => ReadStructure<DynamicArray>(nameof(CpuId)); set => WriteStructure(nameof(CpuId), value); }

        [Offset(64UL)]
        [Length(1)]
        public DynamicArray VariableInfo { get => ReadStructure<DynamicArray>(nameof(VariableInfo)); set => WriteStructure(nameof(VariableInfo), value); }

        public WheaXpfProcessorErrorSection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaXpfProcessorErrorSection>();
        }
    }
}