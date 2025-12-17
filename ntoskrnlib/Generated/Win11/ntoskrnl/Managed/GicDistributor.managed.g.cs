using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_GIC_DISTRIBUTOR")]
    public sealed class GicDistributor : DynamicStructure
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
        public ulong ControllerPhysicalAddress { get => ReadHere<ulong>(nameof(ControllerPhysicalAddress)); set => WriteHere(nameof(ControllerPhysicalAddress), value); }

        [Offset(16UL)]
        public uint GsivBase { get => ReadHere<uint>(nameof(GsivBase)); set => WriteHere(nameof(GsivBase), value); }

        [Offset(20UL)]
        public byte Version { get => ReadHere<byte>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(21UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public GicDistributor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GicDistributor>();
        }
    }
}