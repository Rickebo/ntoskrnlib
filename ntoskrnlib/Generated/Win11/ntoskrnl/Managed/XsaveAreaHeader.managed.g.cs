using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_XSAVE_AREA_HEADER")]
    public sealed class XsaveAreaHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Mask { get => ReadHere<ulong>(nameof(Mask)); set => WriteHere(nameof(Mask), value); }

        [Offset(8UL)]
        public ulong CompactionMask { get => ReadHere<ulong>(nameof(CompactionMask)); set => WriteHere(nameof(CompactionMask), value); }

        [Offset(16UL)]
        [Length(6)]
        public DynamicArray Reserved2 { get => ReadStructure<DynamicArray>(nameof(Reserved2)); set => WriteStructure(nameof(Reserved2), value); }

        public XsaveAreaHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XsaveAreaHeader>();
        }
    }
}