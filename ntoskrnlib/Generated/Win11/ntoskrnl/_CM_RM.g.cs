#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct _CM_RM
    {
        [FieldOffset(0)]
        public _LIST_ENTRY RmListEntry;
        [FieldOffset(16)]
        public _LIST_ENTRY TransactionListHead;
        [FieldOffset(32)]
        public IntPtr TmHandle;
        [FieldOffset(40)]
        public IntPtr Tm;
        [FieldOffset(48)]
        public IntPtr RmHandle;
        [FieldOffset(56)]
        public IntPtr KtmRm;
        [FieldOffset(64)]
        public uint RefCount;
        [FieldOffset(68)]
        public uint ContainerNum;
        [FieldOffset(72)]
        public ulong ContainerSize;
        [FieldOffset(80)]
        public IntPtr CmHive;
        [FieldOffset(88)]
        public IntPtr LogFileObject;
        [FieldOffset(96)]
        public IntPtr MarshallingContext;
        [FieldOffset(104)]
        public uint RmFlags;
        [FieldOffset(108)]
        public int LogStartStatus1;
        [FieldOffset(112)]
        public int LogStartStatus2;
        [FieldOffset(120)]
        public ulong BaseLsn;
        [FieldOffset(128)]
        public IntPtr RmLock;
    }
}