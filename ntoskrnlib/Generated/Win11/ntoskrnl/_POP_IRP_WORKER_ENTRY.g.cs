#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _POP_IRP_WORKER_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public IntPtr Thread;
        [FieldOffset(24)]
        public IntPtr Irp;
        [FieldOffset(32)]
        public IntPtr Device;
        [FieldOffset(40)]
        public byte Static;
    }
}