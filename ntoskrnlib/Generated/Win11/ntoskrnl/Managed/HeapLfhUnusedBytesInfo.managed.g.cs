using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_UNUSED_BYTES_INFO")]
    public sealed class HeapLfhUnusedBytesInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ushort UnusedBytes { get => ReadHere<ushort>(nameof(UnusedBytes)); set => WriteHere(nameof(UnusedBytes), value); }

        [Offset(0UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public ushort ExtraPresent { get => ReadHere<ushort>(nameof(ExtraPresent)); set => WriteHere(nameof(ExtraPresent), value); }

        [Offset(0UL)]
        public ushort OneByteUnused { get => ReadHere<ushort>(nameof(OneByteUnused)); set => WriteHere(nameof(OneByteUnused), value); }

        [Offset(0UL)]
        public ushort UnusedBytesUShort { get => ReadHere<ushort>(nameof(UnusedBytesUShort)); set => WriteHere(nameof(UnusedBytesUShort), value); }

        public HeapLfhUnusedBytesInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhUnusedBytesInfo>();
        }
    }
}