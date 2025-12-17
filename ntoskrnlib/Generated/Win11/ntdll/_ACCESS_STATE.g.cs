#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _ACCESS_STATE
    {
        [FieldOffset(0)]
        public _LUID OperationID;
        [FieldOffset(8)]
        public byte SecurityEvaluated;
        [FieldOffset(9)]
        public byte GenerateAudit;
        [FieldOffset(10)]
        public byte GenerateOnClose;
        [FieldOffset(11)]
        public byte PrivilegesAllocated;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public uint RemainingDesiredAccess;
        [FieldOffset(20)]
        public uint PreviouslyGrantedAccess;
        [FieldOffset(24)]
        public uint OriginalDesiredAccess;
        [FieldOffset(32)]
        public _SECURITY_SUBJECT_CONTEXT SubjectSecurityContext;
        [FieldOffset(64)]
        public IntPtr SecurityDescriptor;
        [FieldOffset(72)]
        public IntPtr AuxData;
        [FieldOffset(80)]
        public _unnamed_tag_ Privileges;
        [FieldOffset(124)]
        public byte AuditPrivileges;
        [FieldOffset(128)]
        public _UNICODE_STRING ObjectName;
        [FieldOffset(144)]
        public _UNICODE_STRING ObjectTypeName;
    }
}