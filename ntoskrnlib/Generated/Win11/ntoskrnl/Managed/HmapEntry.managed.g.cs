using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HMAP_ENTRY")]
    public sealed class HmapEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BlockOffset { get => ReadHere<ulong>(nameof(BlockOffset)); set => WriteHere(nameof(BlockOffset), value); }

        [Offset(8UL)]
        public ulong PermanentBinAddress { get => ReadHere<ulong>(nameof(PermanentBinAddress)); set => WriteHere(nameof(PermanentBinAddress), value); }

        [Offset(16UL)]
        public uint MemAlloc { get => ReadHere<uint>(nameof(MemAlloc)); set => WriteHere(nameof(MemAlloc), value); }

        public HmapEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HmapEntry>();
        }
    }
}