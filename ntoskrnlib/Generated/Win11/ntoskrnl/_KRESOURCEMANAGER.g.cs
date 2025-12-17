#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 592)]
    public partial struct _KRESOURCEMANAGER
    {
        [FieldOffset(0)]
        public _KEVENT NotificationAvailable;
        [FieldOffset(24)]
        public uint cookie;
        [FieldOffset(28)]
        public uint State;
        [FieldOffset(32)]
        public uint Flags;
        [FieldOffset(40)]
        public _KMUTANT Mutex;
        [FieldOffset(96)]
        public _KTMOBJECT_NAMESPACE_LINK NamespaceLink;
        [FieldOffset(136)]
        public _GUID RmId;
        [FieldOffset(152)]
        public _KQUEUE NotificationQueue;
        [FieldOffset(216)]
        public _KMUTANT NotificationMutex;
        [FieldOffset(272)]
        public _LIST_ENTRY EnlistmentHead;
        [FieldOffset(288)]
        public uint EnlistmentCount;
        [FieldOffset(296)]
        public IntPtr NotificationRoutine;
        [FieldOffset(304)]
        public IntPtr Key;
        [FieldOffset(312)]
        public _LIST_ENTRY ProtocolListHead;
        [FieldOffset(328)]
        public _LIST_ENTRY PendingPropReqListHead;
        [FieldOffset(344)]
        public _LIST_ENTRY CRMListEntry;
        [FieldOffset(360)]
        public IntPtr Tm;
        [FieldOffset(368)]
        public _UNICODE_STRING Description;
        [FieldOffset(384)]
        public _KTMOBJECT_NAMESPACE Enlistments;
        [FieldOffset(552)]
        public _KRESOURCEMANAGER_COMPLETION_BINDING CompletionBinding;
    }
}