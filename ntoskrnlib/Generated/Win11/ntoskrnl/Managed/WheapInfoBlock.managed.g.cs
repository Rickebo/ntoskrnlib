using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEAP_INFO_BLOCK")]
    public sealed class WheapInfoBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint ErrorSourceCount { get => ReadHere<uint>(nameof(ErrorSourceCount)); set => WriteHere(nameof(ErrorSourceCount), value); }

        [Offset(8UL)]
        public IntPtr ErrorSourceTable { get => ReadHere<IntPtr>(nameof(ErrorSourceTable)); set => WriteHere(nameof(ErrorSourceTable), value); }

        [Offset(16UL)]
        public IntPtr WorkQueue { get => ReadHere<IntPtr>(nameof(WorkQueue)); set => WriteHere(nameof(WorkQueue), value); }

        public WheapInfoBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheapInfoBlock>();
        }
    }
}