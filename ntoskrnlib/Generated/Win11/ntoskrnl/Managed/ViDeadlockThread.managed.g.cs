using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_THREAD")]
    public sealed class ViDeadlockThread : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(8UL)]
        public IntPtr CurrentSpinNode { get => ReadHere<IntPtr>(nameof(CurrentSpinNode)); set => WriteHere(nameof(CurrentSpinNode), value); }

        [Offset(16UL)]
        public IntPtr CurrentOtherNode { get => ReadHere<IntPtr>(nameof(CurrentOtherNode)); set => WriteHere(nameof(CurrentOtherNode), value); }

        [Offset(24UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(24UL)]
        public ListEntry FreeListEntry { get => ReadStructure<ListEntry>(nameof(FreeListEntry)); set => WriteStructure(nameof(FreeListEntry), value); }

        [Offset(40UL)]
        public uint NodeCount { get => ReadHere<uint>(nameof(NodeCount)); set => WriteHere(nameof(NodeCount), value); }

        [Offset(44UL)]
        public uint PagingCount { get => ReadHere<uint>(nameof(PagingCount)); set => WriteHere(nameof(PagingCount), value); }

        [Offset(48UL)]
        public byte ThreadUsesEresources { get => ReadHere<byte>(nameof(ThreadUsesEresources)); set => WriteHere(nameof(ThreadUsesEresources), value); }

        public ViDeadlockThread(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViDeadlockThread>();
        }
    }
}