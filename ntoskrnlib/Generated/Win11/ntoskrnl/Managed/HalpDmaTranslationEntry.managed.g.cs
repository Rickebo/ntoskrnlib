using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_TRANSLATION_ENTRY")]
    public sealed class HalpDmaTranslationEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PhysicalAddress { get => ReadHere<ulong>(nameof(PhysicalAddress)); set => WriteHere(nameof(PhysicalAddress), value); }

        [Offset(8UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(16UL)]
        public uint MappedLength { get => ReadHere<uint>(nameof(MappedLength)); set => WriteHere(nameof(MappedLength), value); }

        [Offset(24UL)]
        public IommuDmaLogicalAddressTokenMappedSegment RemappingAddress { get => ReadStructure<IommuDmaLogicalAddressTokenMappedSegment>(nameof(RemappingAddress)); set => WriteStructure(nameof(RemappingAddress), value); }

        [Offset(48UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(56UL)]
        public IntPtr NextMapping { get => ReadHere<IntPtr>(nameof(NextMapping)); set => WriteHere(nameof(NextMapping), value); }

        [Offset(64UL)]
        public byte LogicalBounceBufferPremapped { get => ReadHere<byte>(nameof(LogicalBounceBufferPremapped)); set => WriteHere(nameof(LogicalBounceBufferPremapped), value); }

        public HalpDmaTranslationEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaTranslationEntry>();
        }
    }
}