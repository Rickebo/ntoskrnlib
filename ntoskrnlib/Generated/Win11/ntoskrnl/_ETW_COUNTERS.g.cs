#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _ETW_COUNTERS
    {
        [FieldOffset(0)]
        public int GuidCount;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] PoolUsage;
        [FieldOffset(12)]
        public int SessionCount;
    }
}