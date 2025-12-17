using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SEGMENT_HEAP_EXTRA")]
    public sealed class SegmentHeapExtra : DynamicStructure
    {
        [Offset(0UL)]
        public ushort AllocationTag { get => ReadHere<ushort>(nameof(AllocationTag)); set => WriteHere(nameof(AllocationTag), value); }

        [Offset(2UL)]
        public byte InterceptorIndex { get => ReadHere<byte>(nameof(InterceptorIndex)); set => WriteHere(nameof(InterceptorIndex), value); }

        [Offset(2UL)]
        public byte UserFlags { get => ReadHere<byte>(nameof(UserFlags)); set => WriteHere(nameof(UserFlags), value); }

        [Offset(3UL)]
        public byte ExtraSizeInUnits { get => ReadHere<byte>(nameof(ExtraSizeInUnits)); set => WriteHere(nameof(ExtraSizeInUnits), value); }

        [Offset(8UL)]
        public IntPtr Settable { get => ReadHere<IntPtr>(nameof(Settable)); set => WriteHere(nameof(Settable), value); }

        public SegmentHeapExtra(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SegmentHeapExtra>();
        }
    }
}