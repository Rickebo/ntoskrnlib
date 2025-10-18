using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _PROC_PERF_HISTORY
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
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public uint[] TaggedPercentTotal;
    [FieldOffset(44)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] HistoryList;
}
