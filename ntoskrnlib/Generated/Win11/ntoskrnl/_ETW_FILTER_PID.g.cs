#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial struct _ETW_FILTER_PID
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] Pids;
    }
}