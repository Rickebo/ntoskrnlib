#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PCW_COUNTER_INFORMATION
    {
        [FieldOffset(0)]
        public ulong CounterMask;
        [FieldOffset(8)]
        public IntPtr InstanceMask;
    }
}