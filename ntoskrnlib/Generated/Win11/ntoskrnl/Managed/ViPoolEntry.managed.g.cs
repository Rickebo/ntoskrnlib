using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_POOL_ENTRY")]
    public sealed class ViPoolEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ViPoolPageHeader PageHeader { get => ReadStructure<ViPoolPageHeader>(nameof(PageHeader)); set => WriteStructure(nameof(PageHeader), value); }

        [Offset(0UL)]
        public ViPoolEntryInuse InUse { get => ReadStructure<ViPoolEntryInuse>(nameof(InUse)); set => WriteStructure(nameof(InUse), value); }

        [Offset(0UL)]
        public IntPtr NextFree { get => ReadHere<IntPtr>(nameof(NextFree)); set => WriteHere(nameof(NextFree), value); }

        public ViPoolEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViPoolEntry>();
        }
    }
}