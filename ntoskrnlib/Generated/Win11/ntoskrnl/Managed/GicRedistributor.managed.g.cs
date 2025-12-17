using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_GIC_REDISTRIBUTOR")]
    public sealed class GicRedistributor : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public ulong DiscoveryRangeBaseAddress { get => ReadHere<ulong>(nameof(DiscoveryRangeBaseAddress)); set => WriteHere(nameof(DiscoveryRangeBaseAddress), value); }

        [Offset(12UL)]
        public uint DiscoveryRangeLength { get => ReadHere<uint>(nameof(DiscoveryRangeLength)); set => WriteHere(nameof(DiscoveryRangeLength), value); }

        public GicRedistributor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GicRedistributor>();
        }
    }
}