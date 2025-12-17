using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VS_SUBSEGMENT")]
    public sealed class HeapVsSubsegment : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public ulong CommitBitmap { get => ReadHere<ulong>(nameof(CommitBitmap)); set => WriteHere(nameof(CommitBitmap), value); }

        [Offset(24UL)]
        public ulong CommitLock { get => ReadHere<ulong>(nameof(CommitLock)); set => WriteHere(nameof(CommitLock), value); }

        [Offset(32UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(34UL)]
        public ushort OwnerSlotRef { get => ReadHere<ushort>(nameof(OwnerSlotRef)); set => WriteHere(nameof(OwnerSlotRef), value); }

        [Offset(36UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(36UL)]
        public ushort FullCommit { get => ReadHere<ushort>(nameof(FullCommit)); set => WriteHere(nameof(FullCommit), value); }

        public HeapVsSubsegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsSubsegment>();
        }
    }
}