#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct _WNF_PROCESS_CONTEXT
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(8)]
        public IntPtr Process;
        [FieldOffset(16)]
        public _LIST_ENTRY WnfProcessesListEntry;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public IntPtr[] ImplicitScopeInstances;
        [FieldOffset(56)]
        public _WNF_LOCK TemporaryNamesListLock;
        [FieldOffset(64)]
        public _LIST_ENTRY TemporaryNamesListHead;
        [FieldOffset(80)]
        public _WNF_LOCK ProcessSubscriptionListLock;
        [FieldOffset(88)]
        public _LIST_ENTRY ProcessSubscriptionListHead;
        [FieldOffset(104)]
        public _WNF_LOCK DeliveryPendingListLock;
        [FieldOffset(112)]
        public _LIST_ENTRY DeliveryPendingListHead;
        [FieldOffset(128)]
        public IntPtr NotificationEvent;
    }
}