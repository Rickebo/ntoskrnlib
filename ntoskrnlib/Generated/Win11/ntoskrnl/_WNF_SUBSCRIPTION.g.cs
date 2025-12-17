#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct _WNF_SUBSCRIPTION
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(8)]
        public _EX_RUNDOWN_REF RunRef;
        [FieldOffset(16)]
        public ulong SubscriptionId;
        [FieldOffset(24)]
        public _LIST_ENTRY ProcessSubscriptionListEntry;
        [FieldOffset(40)]
        public IntPtr Process;
        [FieldOffset(48)]
        public IntPtr NameInstance;
        [FieldOffset(56)]
        public _WNF_STATE_NAME_STRUCT StateName;
        [FieldOffset(64)]
        public _LIST_ENTRY StateSubscriptionListEntry;
        [FieldOffset(80)]
        public ulong CallbackRoutine;
        [FieldOffset(88)]
        public IntPtr CallbackContext;
        [FieldOffset(96)]
        public uint CurrentChangeStamp;
        [FieldOffset(100)]
        public uint SubscribedEventSet;
        [FieldOffset(104)]
        public _LIST_ENTRY PendingSubscriptionListEntry;
        [FieldOffset(120)]
        public uint SubscriptionState;
        [FieldOffset(124)]
        public uint SignaledEventSet;
        [FieldOffset(128)]
        public uint InDeliveryEventSet;
    }
}