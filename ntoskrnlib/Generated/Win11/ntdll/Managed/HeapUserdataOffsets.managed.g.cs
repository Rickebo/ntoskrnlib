using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_USERDATA_OFFSETS")]
    public sealed class HeapUserdataOffsets : DynamicStructure
    {
        [Offset(0UL)]
        public ushort FirstAllocationOffset { get => ReadHere<ushort>(nameof(FirstAllocationOffset)); set => WriteHere(nameof(FirstAllocationOffset), value); }

        [Offset(2UL)]
        public ushort BlockStride { get => ReadHere<ushort>(nameof(BlockStride)); set => WriteHere(nameof(BlockStride), value); }

        [Offset(0UL)]
        public uint StrideAndOffset { get => ReadHere<uint>(nameof(StrideAndOffset)); set => WriteHere(nameof(StrideAndOffset), value); }

        public HeapUserdataOffsets(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapUserdataOffsets>();
        }
    }
}