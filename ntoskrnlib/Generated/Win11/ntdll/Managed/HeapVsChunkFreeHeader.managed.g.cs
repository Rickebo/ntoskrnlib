using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VS_CHUNK_FREE_HEADER")]
    public sealed class HeapVsChunkFreeHeader : DynamicStructure
    {
        [Offset(0UL)]
        public HeapVsChunkHeader Header { get => ReadStructure<HeapVsChunkHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(0UL)]
        public ulong OverlapsHeader { get => ReadHere<ulong>(nameof(OverlapsHeader)); set => WriteHere(nameof(OverlapsHeader), value); }

        [Offset(8UL)]
        public RtlBalancedNode Node { get => ReadStructure<RtlBalancedNode>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        public HeapVsChunkFreeHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsChunkFreeHeader>();
        }
    }
}