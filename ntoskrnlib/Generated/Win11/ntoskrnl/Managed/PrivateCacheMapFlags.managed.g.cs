using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PRIVATE_CACHE_MAP_FLAGS")]
    public sealed class PrivateCacheMapFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint DontUse { get => ReadHere<uint>(nameof(DontUse)); set => WriteHere(nameof(DontUse), value); }

        [Offset(0UL)]
        public uint ReadAheadActive { get => ReadHere<uint>(nameof(ReadAheadActive)); set => WriteHere(nameof(ReadAheadActive), value); }

        [Offset(0UL)]
        public uint ReadAheadEnabled { get => ReadHere<uint>(nameof(ReadAheadEnabled)); set => WriteHere(nameof(ReadAheadEnabled), value); }

        [Offset(0UL)]
        public uint PagePriority { get => ReadHere<uint>(nameof(PagePriority)); set => WriteHere(nameof(PagePriority), value); }

        [Offset(0UL)]
        public uint PipelineReadAheads { get => ReadHere<uint>(nameof(PipelineReadAheads)); set => WriteHere(nameof(PipelineReadAheads), value); }

        [Offset(0UL)]
        public uint Available { get => ReadHere<uint>(nameof(Available)); set => WriteHere(nameof(Available), value); }

        [Offset(0UL)]
        public uint EntireField { get => ReadHere<uint>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public PrivateCacheMapFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PrivateCacheMapFlags>();
        }
    }
}