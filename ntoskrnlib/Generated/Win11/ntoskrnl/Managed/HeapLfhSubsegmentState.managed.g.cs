using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT_STATE")]
    public sealed class HeapLfhSubsegmentState : DynamicStructure
    {
        [Offset(0UL)]
        public ushort DelayFreeList { get => ReadHere<ushort>(nameof(DelayFreeList)); set => WriteHere(nameof(DelayFreeList), value); }

        [Offset(2UL)]
        public ushort DelayFreeCount { get => ReadHere<ushort>(nameof(DelayFreeCount)); set => WriteHere(nameof(DelayFreeCount), value); }

        [Offset(4UL)]
        public ushort Owner { get => ReadHere<ushort>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(6UL)]
        public byte Location { get => ReadHere<byte>(nameof(Location)); set => WriteHere(nameof(Location), value); }

        [Offset(0UL)]
        public int DelayFreeFields { get => ReadHere<int>(nameof(DelayFreeFields)); set => WriteHere(nameof(DelayFreeFields), value); }

        [Offset(4UL)]
        public int OwnerLocation { get => ReadHere<int>(nameof(OwnerLocation)); set => WriteHere(nameof(OwnerLocation), value); }

        [Offset(0UL)]
        public HeapLfhBlockList FreeList { get => ReadStructure<HeapLfhBlockList>(nameof(FreeList)); set => WriteStructure(nameof(FreeList), value); }

        [Offset(0UL)]
        public IntPtr AllBits { get => ReadHere<IntPtr>(nameof(AllBits)); set => WriteHere(nameof(AllBits), value); }

        public HeapLfhSubsegmentState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhSubsegmentState>();
        }
    }
}