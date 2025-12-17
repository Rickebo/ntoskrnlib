using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_GIC_MSIFRAME_ENTRY")]
    public sealed class GicMsiframeEntry : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort Reserved1 { get => ReadHere<ushort>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(4UL)]
        public uint Identifier { get => ReadHere<uint>(nameof(Identifier)); set => WriteHere(nameof(Identifier), value); }

        [Offset(8UL)]
        public ulong PhysicalAddress { get => ReadHere<ulong>(nameof(PhysicalAddress)); set => WriteHere(nameof(PhysicalAddress), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(20UL)]
        public ushort SpiCount { get => ReadHere<ushort>(nameof(SpiCount)); set => WriteHere(nameof(SpiCount), value); }

        [Offset(22UL)]
        public ushort SpiBase { get => ReadHere<ushort>(nameof(SpiBase)); set => WriteHere(nameof(SpiBase), value); }

        public GicMsiframeEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GicMsiframeEntry>();
        }
    }
}