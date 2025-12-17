#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _CM_TRANS
    {
        [FieldOffset(0)]
        public _LIST_ENTRY TransactionListEntry;
        [FieldOffset(16)]
        public _LIST_ENTRY KCBUoWListHead;
        [FieldOffset(32)]
        public _LIST_ENTRY LazyCommitListEntry;
        [FieldOffset(48)]
        public uint Prepared;
        [FieldOffset(48)]
        public uint Aborted;
        [FieldOffset(48)]
        public uint Committed;
        [FieldOffset(48)]
        public uint Initializing;
        [FieldOffset(48)]
        public uint Invalid;
        [FieldOffset(48)]
        public uint UseReservation;
        [FieldOffset(48)]
        public uint TmCallbacksActive;
        [FieldOffset(48)]
        public uint LightWeight;
        [FieldOffset(48)]
        public uint Freed1;
        [FieldOffset(48)]
        public uint Freed2;
        [FieldOffset(48)]
        public uint Spare1;
        [FieldOffset(48)]
        public uint Freed;
        [FieldOffset(48)]
        public uint Spare;
        [FieldOffset(48)]
        public uint TransState;
        [FieldOffset(56)]
        public _CM_TRANS_PTR Trans;
        [FieldOffset(64)]
        public IntPtr CmRm;
        [FieldOffset(72)]
        public IntPtr KtmEnlistmentObject;
        [FieldOffset(80)]
        public IntPtr KtmEnlistmentHandle;
        [FieldOffset(88)]
        public _GUID KtmUow;
        [FieldOffset(104)]
        public ulong StartLsn;
        [FieldOffset(112)]
        public uint HiveCount;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] HiveArray;
    }
}