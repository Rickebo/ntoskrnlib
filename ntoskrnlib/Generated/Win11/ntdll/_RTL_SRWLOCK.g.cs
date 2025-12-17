#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_SRWLOCK
    {
        [FieldOffset(0)]
        public ulong Locked;
        [FieldOffset(0)]
        public ulong Waiting;
        [FieldOffset(0)]
        public ulong Waking;
        [FieldOffset(0)]
        public ulong MultipleShared;
        [FieldOffset(0)]
        public ulong Shared;
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public IntPtr Ptr;
    }
}