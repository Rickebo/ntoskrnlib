using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=12)]
public struct _PROC_PERF_HISTORY_ENTRY
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
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] TaggedPercent;
}
