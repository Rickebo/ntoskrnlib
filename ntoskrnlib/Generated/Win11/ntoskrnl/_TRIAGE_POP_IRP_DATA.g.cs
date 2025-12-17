#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _TRIAGE_POP_IRP_DATA
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public IntPtr Irp;
        [FieldOffset(24)]
        public IntPtr Pdo;
    }
}