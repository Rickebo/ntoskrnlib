using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS")]
    public sealed class HeapLfhSubsegmentEncodedOffsets : DynamicStructure
    {
        [Offset(0UL)]
        public ushort BlockSize { get => ReadHere<ushort>(nameof(BlockSize)); set => WriteHere(nameof(BlockSize), value); }

        [Offset(2UL)]
        public ushort FirstBlockOffset { get => ReadHere<ushort>(nameof(FirstBlockOffset)); set => WriteHere(nameof(FirstBlockOffset), value); }

        [Offset(0UL)]
        public uint EncodedData { get => ReadHere<uint>(nameof(EncodedData)); set => WriteHere(nameof(EncodedData), value); }

        public HeapLfhSubsegmentEncodedOffsets(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhSubsegmentEncodedOffsets>();
        }
    }
}