#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KSECONDARY_IDT_ENTRY
    {
        [FieldOffset(0)]
        public ulong SpinLock;
        [FieldOffset(8)]
        public _KEVENT ConnectLock;
        [FieldOffset(32)]
        public byte LineMasked;
        [FieldOffset(40)]
        public IntPtr InterruptList;
    }
}