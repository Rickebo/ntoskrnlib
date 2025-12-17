#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PROC_PERF_HISTORY
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(4)]
        public uint Slot;
        [FieldOffset(8)]
        public uint UtilityTotal;
        [FieldOffset(12)]
        public uint AffinitizedUtilityTotal;
        [FieldOffset(16)]
        public uint FrequencyTotal;
        [FieldOffset(20)]
        public uint ImportantPercentTotal;
        [FieldOffset(24)]
        public uint IdealPercentTotal;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] TaggedPercentTotal;
        [FieldOffset(44)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PROC_PERF_HISTORY_ENTRY[] HistoryList;
    }
}