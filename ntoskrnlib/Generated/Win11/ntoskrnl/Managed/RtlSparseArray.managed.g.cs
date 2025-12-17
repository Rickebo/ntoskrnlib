using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_SPARSE_ARRAY")]
    public sealed class RtlSparseArray : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ElementCount { get => ReadHere<ulong>(nameof(ElementCount)); set => WriteHere(nameof(ElementCount), value); }

        [Offset(8UL)]
        public uint ElementSizeShift { get => ReadHere<uint>(nameof(ElementSizeShift)); set => WriteHere(nameof(ElementSizeShift), value); }

        [Offset(16UL)]
        public RtlCsparseBitmap Bitmap { get => ReadStructure<RtlCsparseBitmap>(nameof(Bitmap)); set => WriteStructure(nameof(Bitmap), value); }

        public RtlSparseArray(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlSparseArray>();
        }
    }
}