using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_REVISION")]
    public sealed class WheaRevision : DynamicStructure
    {
        [Offset(0UL)]
        public byte MinorRevision { get => ReadHere<byte>(nameof(MinorRevision)); set => WriteHere(nameof(MinorRevision), value); }

        [Offset(1UL)]
        public byte MajorRevision { get => ReadHere<byte>(nameof(MajorRevision)); set => WriteHere(nameof(MajorRevision), value); }

        [Offset(0UL)]
        public ushort AsUSHORT { get => ReadHere<ushort>(nameof(AsUSHORT)); set => WriteHere(nameof(AsUSHORT), value); }

        public WheaRevision(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaRevision>();
        }
    }
}