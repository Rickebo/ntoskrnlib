using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_MEMORY_ERROR_SECTION_VALIDBITS")]
    public sealed class WheaMemoryErrorSectionValidbits : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ErrorStatus { get => ReadHere<ulong>(nameof(ErrorStatus)); set => WriteHere(nameof(ErrorStatus), value); }

        [Offset(0UL)]
        public ulong PhysicalAddress { get => ReadHere<ulong>(nameof(PhysicalAddress)); set => WriteHere(nameof(PhysicalAddress), value); }

        [Offset(0UL)]
        public ulong PhysicalAddressMask { get => ReadHere<ulong>(nameof(PhysicalAddressMask)); set => WriteHere(nameof(PhysicalAddressMask), value); }

        [Offset(0UL)]
        public ulong Node { get => ReadHere<ulong>(nameof(Node)); set => WriteHere(nameof(Node), value); }

        [Offset(0UL)]
        public ulong Card { get => ReadHere<ulong>(nameof(Card)); set => WriteHere(nameof(Card), value); }

        [Offset(0UL)]
        public ulong Module { get => ReadHere<ulong>(nameof(Module)); set => WriteHere(nameof(Module), value); }

        [Offset(0UL)]
        public ulong Bank { get => ReadHere<ulong>(nameof(Bank)); set => WriteHere(nameof(Bank), value); }

        [Offset(0UL)]
        public ulong Device { get => ReadHere<ulong>(nameof(Device)); set => WriteHere(nameof(Device), value); }

        [Offset(0UL)]
        public ulong Row { get => ReadHere<ulong>(nameof(Row)); set => WriteHere(nameof(Row), value); }

        [Offset(0UL)]
        public ulong Column { get => ReadHere<ulong>(nameof(Column)); set => WriteHere(nameof(Column), value); }

        [Offset(0UL)]
        public ulong BitPosition { get => ReadHere<ulong>(nameof(BitPosition)); set => WriteHere(nameof(BitPosition), value); }

        [Offset(0UL)]
        public ulong RequesterId { get => ReadHere<ulong>(nameof(RequesterId)); set => WriteHere(nameof(RequesterId), value); }

        [Offset(0UL)]
        public ulong ResponderId { get => ReadHere<ulong>(nameof(ResponderId)); set => WriteHere(nameof(ResponderId), value); }

        [Offset(0UL)]
        public ulong TargetId { get => ReadHere<ulong>(nameof(TargetId)); set => WriteHere(nameof(TargetId), value); }

        [Offset(0UL)]
        public ulong ErrorType { get => ReadHere<ulong>(nameof(ErrorType)); set => WriteHere(nameof(ErrorType), value); }

        [Offset(0UL)]
        public ulong RankNumber { get => ReadHere<ulong>(nameof(RankNumber)); set => WriteHere(nameof(RankNumber), value); }

        [Offset(0UL)]
        public ulong CardHandle { get => ReadHere<ulong>(nameof(CardHandle)); set => WriteHere(nameof(CardHandle), value); }

        [Offset(0UL)]
        public ulong ModuleHandle { get => ReadHere<ulong>(nameof(ModuleHandle)); set => WriteHere(nameof(ModuleHandle), value); }

        [Offset(0UL)]
        public ulong ExtendedRow { get => ReadHere<ulong>(nameof(ExtendedRow)); set => WriteHere(nameof(ExtendedRow), value); }

        [Offset(0UL)]
        public ulong BankGroup { get => ReadHere<ulong>(nameof(BankGroup)); set => WriteHere(nameof(BankGroup), value); }

        [Offset(0UL)]
        public ulong BankAddress { get => ReadHere<ulong>(nameof(BankAddress)); set => WriteHere(nameof(BankAddress), value); }

        [Offset(0UL)]
        public ulong ChipIdentification { get => ReadHere<ulong>(nameof(ChipIdentification)); set => WriteHere(nameof(ChipIdentification), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong ValidBits { get => ReadHere<ulong>(nameof(ValidBits)); set => WriteHere(nameof(ValidBits), value); }

        public WheaMemoryErrorSectionValidbits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaMemoryErrorSectionValidbits>();
        }
    }
}