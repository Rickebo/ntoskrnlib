using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS")]
    public sealed class WheaProcessorGenericErrorSectionValidbits : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ProcessorType { get => ReadHere<ulong>(nameof(ProcessorType)); set => WriteHere(nameof(ProcessorType), value); }

        [Offset(0UL)]
        public ulong InstructionSet { get => ReadHere<ulong>(nameof(InstructionSet)); set => WriteHere(nameof(InstructionSet), value); }

        [Offset(0UL)]
        public ulong ErrorType { get => ReadHere<ulong>(nameof(ErrorType)); set => WriteHere(nameof(ErrorType), value); }

        [Offset(0UL)]
        public ulong Operation { get => ReadHere<ulong>(nameof(Operation)); set => WriteHere(nameof(Operation), value); }

        [Offset(0UL)]
        public ulong Flags { get => ReadHere<ulong>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(0UL)]
        public ulong Level { get => ReadHere<ulong>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(0UL)]
        public ulong CPUVersion { get => ReadHere<ulong>(nameof(CPUVersion)); set => WriteHere(nameof(CPUVersion), value); }

        [Offset(0UL)]
        public ulong CPUBrandString { get => ReadHere<ulong>(nameof(CPUBrandString)); set => WriteHere(nameof(CPUBrandString), value); }

        [Offset(0UL)]
        public ulong ProcessorId { get => ReadHere<ulong>(nameof(ProcessorId)); set => WriteHere(nameof(ProcessorId), value); }

        [Offset(0UL)]
        public ulong TargetAddress { get => ReadHere<ulong>(nameof(TargetAddress)); set => WriteHere(nameof(TargetAddress), value); }

        [Offset(0UL)]
        public ulong RequesterId { get => ReadHere<ulong>(nameof(RequesterId)); set => WriteHere(nameof(RequesterId), value); }

        [Offset(0UL)]
        public ulong ResponderId { get => ReadHere<ulong>(nameof(ResponderId)); set => WriteHere(nameof(ResponderId), value); }

        [Offset(0UL)]
        public ulong InstructionPointer { get => ReadHere<ulong>(nameof(InstructionPointer)); set => WriteHere(nameof(InstructionPointer), value); }

        [Offset(0UL)]
        public ulong NativeModelId { get => ReadHere<ulong>(nameof(NativeModelId)); set => WriteHere(nameof(NativeModelId), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong ValidBits { get => ReadHere<ulong>(nameof(ValidBits)); set => WriteHere(nameof(ValidBits), value); }

        public WheaProcessorGenericErrorSectionValidbits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaProcessorGenericErrorSectionValidbits>();
        }
    }
}