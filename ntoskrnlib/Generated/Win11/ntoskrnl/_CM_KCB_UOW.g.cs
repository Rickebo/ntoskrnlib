#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _CM_KCB_UOW
    {
        [FieldOffset(0)]
        public _LIST_ENTRY TransactionListEntry;
        [FieldOffset(16)]
        public IntPtr KCBLock;
        [FieldOffset(24)]
        public IntPtr KeyLock;
        [FieldOffset(32)]
        public _LIST_ENTRY KCBListEntry;
        [FieldOffset(48)]
        public IntPtr KeyControlBlock;
        [FieldOffset(56)]
        public IntPtr Transaction;
        [FieldOffset(64)]
        public uint UoWState;
        [FieldOffset(68)]
        public uint ActionType;
        [FieldOffset(72)]
        public uint StorageType;
        [FieldOffset(80)]
        public IntPtr ParentUoW;
        [FieldOffset(88)]
        public IntPtr ChildKCB;
        [FieldOffset(88)]
        public uint VolatileKeyCell;
        [FieldOffset(88)]
        public uint OldValueCell;
        [FieldOffset(92)]
        public uint NewValueCell;
        [FieldOffset(88)]
        public uint UserFlags;
        [FieldOffset(88)]
        public _LARGE_INTEGER LastWriteTime;
        [FieldOffset(88)]
        public IntPtr TxCachedSecurity;
        [FieldOffset(96)]
        public uint TxSecurityCell;
        [FieldOffset(100)]
        public byte UpdateEntireSecurity;
        [FieldOffset(104)]
        public IntPtr PrepareDataPointer;
        [FieldOffset(104)]
        public IntPtr SecurityData;
        [FieldOffset(104)]
        public IntPtr ModifyKeysData;
        [FieldOffset(104)]
        public IntPtr SetValueData;
        [FieldOffset(112)]
        public IntPtr ValueData;
        [FieldOffset(112)]
        public IntPtr DiscardReplaceContext;
    }
}