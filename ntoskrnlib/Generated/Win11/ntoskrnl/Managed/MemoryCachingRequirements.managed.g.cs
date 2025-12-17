using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MEMORY_CACHING_REQUIREMENTS")]
    public sealed class MemoryCachingRequirements : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BasePage { get => ReadHere<ulong>(nameof(BasePage)); set => WriteHere(nameof(BasePage), value); }

        [Offset(8UL)]
        public ulong PageCount { get => ReadHere<ulong>(nameof(PageCount)); set => WriteHere(nameof(PageCount), value); }

        [Offset(16UL)]
        public uint MemoryCachingType { get => ReadHere<uint>(nameof(MemoryCachingType)); set => WriteHere(nameof(MemoryCachingType), value); }

        public MemoryCachingRequirements(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MemoryCachingRequirements>();
        }
    }
}