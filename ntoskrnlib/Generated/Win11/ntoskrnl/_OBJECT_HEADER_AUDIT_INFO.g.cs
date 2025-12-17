#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OBJECT_HEADER_AUDIT_INFO
    {
        [FieldOffset(0)]
        public IntPtr SecurityDescriptor;
        [FieldOffset(8)]
        public ulong Reserved;
    }
}