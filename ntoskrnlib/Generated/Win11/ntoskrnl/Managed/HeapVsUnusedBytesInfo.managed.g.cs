using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_VS_UNUSED_BYTES_INFO")]
    public sealed class HeapVsUnusedBytesInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ushort UnusedBytes { get => ReadHere<ushort>(nameof(UnusedBytes)); set => WriteHere(nameof(UnusedBytes), value); }

        [Offset(0UL)]
        public ushort LfhSubsegment { get => ReadHere<ushort>(nameof(LfhSubsegment)); set => WriteHere(nameof(LfhSubsegment), value); }

        [Offset(0UL)]
        public ushort ExtraPresent { get => ReadHere<ushort>(nameof(ExtraPresent)); set => WriteHere(nameof(ExtraPresent), value); }

        [Offset(0UL)]
        public ushort OneByteUnused { get => ReadHere<ushort>(nameof(OneByteUnused)); set => WriteHere(nameof(OneByteUnused), value); }

        [Offset(0UL)]
        [Length(2)]
        public DynamicArray Bytes { get => ReadStructure<DynamicArray>(nameof(Bytes)); set => WriteStructure(nameof(Bytes), value); }

        public HeapVsUnusedBytesInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsUnusedBytesInfo>();
        }
    }
}