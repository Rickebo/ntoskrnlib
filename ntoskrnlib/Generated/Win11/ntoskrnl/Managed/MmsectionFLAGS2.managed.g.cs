using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMSECTION_FLAGS2")]
    public sealed class MmsectionFLAGS2 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort PartitionId { get => ReadHere<ushort>(nameof(PartitionId)); set => WriteHere(nameof(PartitionId), value); }

        [Offset(2UL)]
        public byte NoCrossPartitionAccess { get => ReadHere<byte>(nameof(NoCrossPartitionAccess)); set => WriteHere(nameof(NoCrossPartitionAccess), value); }

        [Offset(2UL)]
        public byte SubsectionCrossPartitionReferenceOverflow { get => ReadHere<byte>(nameof(SubsectionCrossPartitionReferenceOverflow)); set => WriteHere(nameof(SubsectionCrossPartitionReferenceOverflow), value); }

        [Offset(2UL)]
        public byte UsingFileExtents { get => ReadHere<byte>(nameof(UsingFileExtents)); set => WriteHere(nameof(UsingFileExtents), value); }

        public MmsectionFLAGS2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsectionFLAGS2>();
        }
    }
}