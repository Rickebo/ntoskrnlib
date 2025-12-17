using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCW_DATA")]
    public sealed class PcwData : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Data { get => ReadHere<IntPtr>(nameof(Data)); set => WriteHere(nameof(Data), value); }

        [Offset(8UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public PcwData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcwData>();
        }
    }
}