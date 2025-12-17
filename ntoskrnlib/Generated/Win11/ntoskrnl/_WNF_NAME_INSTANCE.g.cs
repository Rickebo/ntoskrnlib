#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public partial struct _WNF_NAME_INSTANCE
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(8)]
        public _EX_RUNDOWN_REF RunRef;
        [FieldOffset(16)]
        public _RTL_BALANCED_NODE TreeLinks;
        [FieldOffset(40)]
        public _WNF_STATE_NAME_STRUCT StateName;
        [FieldOffset(48)]
        public IntPtr ScopeInstance;
        [FieldOffset(56)]
        public _WNF_STATE_NAME_REGISTRATION StateNameInfo;
        [FieldOffset(80)]
        public _WNF_LOCK StateDataLock;
        [FieldOffset(88)]
        public IntPtr StateData;
        [FieldOffset(96)]
        public uint CurrentChangeStamp;
        [FieldOffset(104)]
        public IntPtr PermanentDataStore;
        [FieldOffset(112)]
        public _WNF_LOCK StateSubscriptionListLock;
        [FieldOffset(120)]
        public _LIST_ENTRY StateSubscriptionListHead;
        [FieldOffset(136)]
        public _LIST_ENTRY TemporaryNameListEntry;
        [FieldOffset(152)]
        public IntPtr CreatorProcess;
        [FieldOffset(160)]
        public int DataSubscribersCount;
        [FieldOffset(164)]
        public int CurrentDeliveryCount;
    }
}