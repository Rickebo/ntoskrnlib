#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _HIVE_WAIT_PACKET
    {
        [FieldOffset(0)]
        public _KEVENT WakeEvent;
        [FieldOffset(24)]
        public int Status;
        [FieldOffset(32)]
        public IntPtr Next;
    }
}