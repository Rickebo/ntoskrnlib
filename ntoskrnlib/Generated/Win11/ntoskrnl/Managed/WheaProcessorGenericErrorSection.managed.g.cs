using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_PROCESSOR_GENERIC_ERROR_SECTION")]
    public sealed class WheaProcessorGenericErrorSection : DynamicStructure
    {
        [Offset(0UL)]
        public WheaProcessorGenericErrorSectionValidbits ValidBits { get => ReadStructure<WheaProcessorGenericErrorSectionValidbits>(nameof(ValidBits)); set => WriteStructure(nameof(ValidBits), value); }

        [Offset(8UL)]
        public byte ProcessorType { get => ReadHere<byte>(nameof(ProcessorType)); set => WriteHere(nameof(ProcessorType), value); }

        [Offset(9UL)]
        public byte InstructionSet { get => ReadHere<byte>(nameof(InstructionSet)); set => WriteHere(nameof(InstructionSet), value); }

        [Offset(10UL)]
        public byte ErrorType { get => ReadHere<byte>(nameof(ErrorType)); set => WriteHere(nameof(ErrorType), value); }

        [Offset(11UL)]
        public byte Operation { get => ReadHere<byte>(nameof(Operation)); set => WriteHere(nameof(Operation), value); }

        [Offset(12UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(13UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(14UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        public ulong CPUVersion { get => ReadHere<ulong>(nameof(CPUVersion)); set => WriteHere(nameof(CPUVersion), value); }

        [Offset(24UL)]
        [Length(128)]
        public DynamicArray CPUBrandString { get => ReadStructure<DynamicArray>(nameof(CPUBrandString)); set => WriteStructure(nameof(CPUBrandString), value); }

        [Offset(152UL)]
        public ulong ProcessorId { get => ReadHere<ulong>(nameof(ProcessorId)); set => WriteHere(nameof(ProcessorId), value); }

        [Offset(160UL)]
        public ulong TargetAddress { get => ReadHere<ulong>(nameof(TargetAddress)); set => WriteHere(nameof(TargetAddress), value); }

        [Offset(168UL)]
        public ulong RequesterId { get => ReadHere<ulong>(nameof(RequesterId)); set => WriteHere(nameof(RequesterId), value); }

        [Offset(176UL)]
        public ulong ResponderId { get => ReadHere<ulong>(nameof(ResponderId)); set => WriteHere(nameof(ResponderId), value); }

        [Offset(184UL)]
        public ulong InstructionPointer { get => ReadHere<ulong>(nameof(InstructionPointer)); set => WriteHere(nameof(InstructionPointer), value); }

        public WheaProcessorGenericErrorSection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaProcessorGenericErrorSection>();
        }
    }
}