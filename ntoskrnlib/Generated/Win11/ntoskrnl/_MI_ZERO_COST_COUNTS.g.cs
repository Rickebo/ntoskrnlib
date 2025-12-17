#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MI_ZERO_COST_COUNTS
    {
        [FieldOffset(0)]
        public ulong NativeSum;
        [FieldOffset(8)]
        public ulong AlternateSum;
    }
}