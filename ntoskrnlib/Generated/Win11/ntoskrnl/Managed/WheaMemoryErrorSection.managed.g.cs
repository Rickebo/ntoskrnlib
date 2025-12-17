using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_MEMORY_ERROR_SECTION")]
    public sealed class WheaMemoryErrorSection : DynamicStructure
    {
        [Offset(0UL)]
        public WheaMemoryErrorSectionValidbits ValidBits { get => ReadStructure<WheaMemoryErrorSectionValidbits>(nameof(ValidBits)); set => WriteStructure(nameof(ValidBits), value); }

        [Offset(8UL)]
        public WheaErrorStatus ErrorStatus { get => ReadStructure<WheaErrorStatus>(nameof(ErrorStatus)); set => WriteStructure(nameof(ErrorStatus), value); }

        [Offset(16UL)]
        public ulong PhysicalAddress { get => ReadHere<ulong>(nameof(PhysicalAddress)); set => WriteHere(nameof(PhysicalAddress), value); }

        [Offset(24UL)]
        public ulong PhysicalAddressMask { get => ReadHere<ulong>(nameof(PhysicalAddressMask)); set => WriteHere(nameof(PhysicalAddressMask), value); }

        [Offset(32UL)]
        public ushort Node { get => ReadHere<ushort>(nameof(Node)); set => WriteHere(nameof(Node), value); }

        [Offset(34UL)]
        public ushort Card { get => ReadHere<ushort>(nameof(Card)); set => WriteHere(nameof(Card), value); }

        [Offset(36UL)]
        public ushort Module { get => ReadHere<ushort>(nameof(Module)); set => WriteHere(nameof(Module), value); }

        [Offset(38UL)]
        public ushort Bank { get => ReadHere<ushort>(nameof(Bank)); set => WriteHere(nameof(Bank), value); }

        [Offset(40UL)]
        public ushort Device { get => ReadHere<ushort>(nameof(Device)); set => WriteHere(nameof(Device), value); }

        [Offset(42UL)]
        public ushort Row { get => ReadHere<ushort>(nameof(Row)); set => WriteHere(nameof(Row), value); }

        [Offset(44UL)]
        public ushort Column { get => ReadHere<ushort>(nameof(Column)); set => WriteHere(nameof(Column), value); }

        [Offset(46UL)]
        public ushort BitPosition { get => ReadHere<ushort>(nameof(BitPosition)); set => WriteHere(nameof(BitPosition), value); }

        [Offset(48UL)]
        public ulong RequesterId { get => ReadHere<ulong>(nameof(RequesterId)); set => WriteHere(nameof(RequesterId), value); }

        [Offset(56UL)]
        public ulong ResponderId { get => ReadHere<ulong>(nameof(ResponderId)); set => WriteHere(nameof(ResponderId), value); }

        [Offset(64UL)]
        public ulong TargetId { get => ReadHere<ulong>(nameof(TargetId)); set => WriteHere(nameof(TargetId), value); }

        [Offset(72UL)]
        public byte ErrorType { get => ReadHere<byte>(nameof(ErrorType)); set => WriteHere(nameof(ErrorType), value); }

        [Offset(73UL)]
        public byte Extended { get => ReadHere<byte>(nameof(Extended)); set => WriteHere(nameof(Extended), value); }

        [Offset(74UL)]
        public ushort RankNumber { get => ReadHere<ushort>(nameof(RankNumber)); set => WriteHere(nameof(RankNumber), value); }

        [Offset(76UL)]
        public ushort CardHandle { get => ReadHere<ushort>(nameof(CardHandle)); set => WriteHere(nameof(CardHandle), value); }

        [Offset(78UL)]
        public ushort ModuleHandle { get => ReadHere<ushort>(nameof(ModuleHandle)); set => WriteHere(nameof(ModuleHandle), value); }

        public WheaMemoryErrorSection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaMemoryErrorSection>();
        }
    }
}