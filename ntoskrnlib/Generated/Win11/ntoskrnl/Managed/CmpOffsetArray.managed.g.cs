using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!CMP_OFFSET_ARRAY")]
    public sealed class CmpOffsetArray : DynamicStructure
    {
        [Offset(0UL)]
        public uint FileOffset { get => ReadHere<uint>(nameof(FileOffset)); set => WriteHere(nameof(FileOffset), value); }

        [Offset(8UL)]
        public IntPtr DataBuffer { get => ReadHere<IntPtr>(nameof(DataBuffer)); set => WriteHere(nameof(DataBuffer), value); }

        [Offset(16UL)]
        public uint DataLength { get => ReadHere<uint>(nameof(DataLength)); set => WriteHere(nameof(DataLength), value); }

        public CmpOffsetArray(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmpOffsetArray>();
        }
    }
}