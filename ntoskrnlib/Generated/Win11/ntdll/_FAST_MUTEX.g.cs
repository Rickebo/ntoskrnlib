#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _FAST_MUTEX
    {
        [FieldOffset(0)]
        public int Count;
        [FieldOffset(8)]
        public IntPtr Owner;
        [FieldOffset(16)]
        public uint Contention;
        [FieldOffset(24)]
        public _KEVENT Event;
        [FieldOffset(48)]
        public uint OldIrql;
    }
}