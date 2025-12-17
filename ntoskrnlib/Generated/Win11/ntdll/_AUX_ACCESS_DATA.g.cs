#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial struct _AUX_ACCESS_DATA
    {
        [FieldOffset(0)]
        public IntPtr PrivilegesUsed;
        [FieldOffset(8)]
        public _GENERIC_MAPPING GenericMapping;
        [FieldOffset(24)]
        public uint AccessesToAudit;
        [FieldOffset(28)]
        public uint MaximumAuditMask;
        [FieldOffset(32)]
        public _GUID TransactionId;
        [FieldOffset(48)]
        public IntPtr NewSecurityDescriptor;
        [FieldOffset(56)]
        public IntPtr ExistingSecurityDescriptor;
        [FieldOffset(64)]
        public IntPtr ParentSecurityDescriptor;
        [FieldOffset(72)]
        public IntPtr DeRefSecurityDescriptor;
        [FieldOffset(80)]
        public IntPtr SDLock;
        [FieldOffset(88)]
        public _ACCESS_REASONS AccessReasons;
        [FieldOffset(216)]
        public byte GenerateStagingEvents;
    }
}