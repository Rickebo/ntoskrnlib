using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MEMORY_MIRRORING_DATA")]
    public sealed class MemoryMirroringData : DynamicStructure
    {
        [Offset(0UL)]
        public uint MemoryRangeCount { get => ReadHere<uint>(nameof(MemoryRangeCount)); set => WriteHere(nameof(MemoryRangeCount), value); }

        [Offset(4UL)]
        public uint IoSpaceRangeCount { get => ReadHere<uint>(nameof(IoSpaceRangeCount)); set => WriteHere(nameof(IoSpaceRangeCount), value); }

        [Offset(8UL)]
        public IntPtr MemoryRanges { get => ReadHere<IntPtr>(nameof(MemoryRanges)); set => WriteHere(nameof(MemoryRanges), value); }

        [Offset(16UL)]
        public IntPtr IoSpaceRanges { get => ReadHere<IntPtr>(nameof(IoSpaceRanges)); set => WriteHere(nameof(IoSpaceRanges), value); }

        public MemoryMirroringData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MemoryMirroringData>();
        }
    }
}