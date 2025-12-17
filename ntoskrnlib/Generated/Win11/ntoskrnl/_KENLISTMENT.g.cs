#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 480)]
    public partial struct _KENLISTMENT
    {
        [FieldOffset(0)]
        public uint cookie;
        [FieldOffset(8)]
        public _KTMOBJECT_NAMESPACE_LINK NamespaceLink;
        [FieldOffset(48)]
        public _GUID EnlistmentId;
        [FieldOffset(64)]
        public _KMUTANT Mutex;
        [FieldOffset(120)]
        public _LIST_ENTRY NextSameTx;
        [FieldOffset(136)]
        public _LIST_ENTRY NextSameRm;
        [FieldOffset(152)]
        public IntPtr ResourceManager;
        [FieldOffset(160)]
        public IntPtr Transaction;
        [FieldOffset(168)]
        public uint State;
        [FieldOffset(172)]
        public uint Flags;
        [FieldOffset(176)]
        public uint NotificationMask;
        [FieldOffset(184)]
        public IntPtr Key;
        [FieldOffset(192)]
        public uint KeyRefCount;
        [FieldOffset(200)]
        public IntPtr RecoveryInformation;
        [FieldOffset(208)]
        public uint RecoveryInformationLength;
        [FieldOffset(216)]
        public IntPtr DynamicNameInformation;
        [FieldOffset(224)]
        public uint DynamicNameInformationLength;
        [FieldOffset(232)]
        public IntPtr FinalNotification;
        [FieldOffset(240)]
        public IntPtr SupSubEnlistment;
        [FieldOffset(248)]
        public IntPtr SupSubEnlHandle;
        [FieldOffset(256)]
        public IntPtr SubordinateTxHandle;
        [FieldOffset(264)]
        public _GUID CrmEnlistmentEnId;
        [FieldOffset(280)]
        public _GUID CrmEnlistmentTmId;
        [FieldOffset(296)]
        public _GUID CrmEnlistmentRmId;
        [FieldOffset(312)]
        public uint NextHistory;
        [FieldOffset(316)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public _KENLISTMENT_HISTORY[] History;
    }
}