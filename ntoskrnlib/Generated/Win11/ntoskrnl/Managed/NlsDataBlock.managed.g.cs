using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NLS_DATA_BLOCK")]
    public sealed class NlsDataBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr AnsiCodePageData { get => ReadHere<IntPtr>(nameof(AnsiCodePageData)); set => WriteHere(nameof(AnsiCodePageData), value); }

        [Offset(8UL)]
        public IntPtr OemCodePageData { get => ReadHere<IntPtr>(nameof(OemCodePageData)); set => WriteHere(nameof(OemCodePageData), value); }

        [Offset(16UL)]
        public IntPtr UnicodeCaseTableData { get => ReadHere<IntPtr>(nameof(UnicodeCaseTableData)); set => WriteHere(nameof(UnicodeCaseTableData), value); }

        public NlsDataBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NlsDataBlock>();
        }
    }
}