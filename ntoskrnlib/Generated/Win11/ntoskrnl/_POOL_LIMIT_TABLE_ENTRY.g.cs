#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _POOL_LIMIT_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public _RTL_HASH_ENTRY HashEntry;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(8)]
        public _SINGLE_LIST_ENTRY SListEntry;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _POOL_LIMIT_INFO[] LimitInfo;
        [FieldOffset(64)]
        public _WNF_STATE_NAME NotificationObject;
        [FieldOffset(80)]
        public _SLIST_ENTRY NotificationEntry;
        [FieldOffset(96)]
        public uint Scheduled;
    }
}