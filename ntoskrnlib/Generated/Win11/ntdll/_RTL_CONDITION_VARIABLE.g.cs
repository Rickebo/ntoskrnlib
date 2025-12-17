#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_CONDITION_VARIABLE
    {
        [FieldOffset(0)]
        public ulong WakeCount;
        [FieldOffset(0)]
        public ulong Waking;
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public IntPtr Ptr;
    }
}