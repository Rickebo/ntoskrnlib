#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _PROC_PERF_HISTORY_ENTRY
    {
        [FieldOffset(0)]
        public ushort Utility;
        [FieldOffset(2)]
        public ushort AffinitizedUtility;
        [FieldOffset(4)]
        public ushort Frequency;
        [FieldOffset(6)]
        public byte ImportantPercent;
        [FieldOffset(7)]
        public byte IdealPercent;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] TaggedPercent;
    }
}