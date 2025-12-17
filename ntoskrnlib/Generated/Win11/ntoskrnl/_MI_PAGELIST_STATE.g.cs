#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public partial struct _MI_PAGELIST_STATE
    {
        [FieldOffset(0)]
        public int ActiveSpinLock;
        [FieldOffset(8)]
        public _RTL_AVL_TREE ActiveThreadTree;
        [FieldOffset(16)]
        public int ActiveZeroSpinLock;
        [FieldOffset(24)]
        public _RTL_AVL_TREE ActiveZeroThreadTree;
        [FieldOffset(32)]
        public _MMPFN LargePfnTemplate;
        [FieldOffset(80)]
        public _MMPFN LargePfnBasePageTemplate;
        [FieldOffset(128)]
        public uint NumberOfZeroFreePageListHeads;
        [FieldOffset(136)]
        public _KEVENT Phase1BootComplete;
        [FieldOffset(160)]
        public _RTL_AVL_TREE PendingBadPageTree;
        [FieldOffset(168)]
        public ulong PendingBadPageCount;
        [FieldOffset(176)]
        public int PendingBadPageTreeLock;
        [FieldOffset(184)]
        public ulong PendingBadPagesWithoutNodesCount;
        [FieldOffset(192)]
        public _LIST_ENTRY PendingBadPageNodesAwaitingDeleteList;
        [FieldOffset(208)]
        public ulong PendingBadPageNodesAwaitingDeleteCount;
        [FieldOffset(216)]
        public byte PendingBadPageNodeDeleteActive;
        [FieldOffset(224)]
        public _WORK_QUEUE_ITEM PendingBadPageNodeDeleteWorkItem;
        [FieldOffset(256)]
        public _RTL_AVL_TREE BadHugePageTree;
        [FieldOffset(264)]
        public ulong BadHugePageCount;
    }
}