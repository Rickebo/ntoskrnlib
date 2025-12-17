#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _SEP_AUDIT_POLICY
    {
        [FieldOffset(0)]
        public _TOKEN_AUDIT_POLICY AdtTokenPolicy;
        [FieldOffset(31)]
        public byte PolicySetStatus;
    }
}