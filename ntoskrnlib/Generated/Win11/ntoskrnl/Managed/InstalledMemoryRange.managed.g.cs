using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INSTALLED_MEMORY_RANGE")]
    public sealed class InstalledMemoryRange : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BasePage { get => ReadHere<ulong>(nameof(BasePage)); set => WriteHere(nameof(BasePage), value); }

        [Offset(8UL)]
        public ulong PageCount { get => ReadHere<ulong>(nameof(PageCount)); set => WriteHere(nameof(PageCount), value); }

        public InstalledMemoryRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InstalledMemoryRange>();
        }
    }
}