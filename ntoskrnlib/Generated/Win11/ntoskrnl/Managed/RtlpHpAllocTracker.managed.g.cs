using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTLP_HP_ALLOC_TRACKER")]
    public sealed class RtlpHpAllocTracker : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BaseAddress { get => ReadHere<ulong>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(8UL)]
        public RtlCsparseBitmap AllocTrackerBitmap { get => ReadStructure<RtlCsparseBitmap>(nameof(AllocTrackerBitmap)); set => WriteStructure(nameof(AllocTrackerBitmap), value); }

        [Offset(8UL)]
        [Length(72)]
        public DynamicArray AllocTrackerBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(AllocTrackerBitmapBuffer)); set => WriteStructure(nameof(AllocTrackerBitmapBuffer), value); }

        public RtlpHpAllocTracker(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHpAllocTracker>();
        }
    }
}