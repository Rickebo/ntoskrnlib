using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OSLOADER_PAGE_TABLE_LOG")]
    public sealed class OsloaderPageTableLog : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LegacyPte { get => ReadHere<IntPtr>(nameof(LegacyPte)); set => WriteHere(nameof(LegacyPte), value); }

        [Offset(8UL)]
        public ulong Pfn { get => ReadHere<ulong>(nameof(Pfn)); set => WriteHere(nameof(Pfn), value); }

        [Offset(16UL)]
        public uint MemoryType { get => ReadHere<uint>(nameof(MemoryType)); set => WriteHere(nameof(MemoryType), value); }

        [Offset(24UL)]
        public ulong BasePage { get => ReadHere<ulong>(nameof(BasePage)); set => WriteHere(nameof(BasePage), value); }

        [Offset(32UL)]
        public ulong PageCount { get => ReadHere<ulong>(nameof(PageCount)); set => WriteHere(nameof(PageCount), value); }

        public OsloaderPageTableLog(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<OsloaderPageTableLog>();
        }
    }
}