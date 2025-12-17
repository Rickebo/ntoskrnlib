#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _SECURITY_SUBJECT_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr ClientToken;
        [FieldOffset(8)]
        public uint ImpersonationLevel;
        [FieldOffset(16)]
        public IntPtr PrimaryToken;
        [FieldOffset(24)]
        public IntPtr ProcessAuditId;
    }
}