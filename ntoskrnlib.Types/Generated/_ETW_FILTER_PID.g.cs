using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=36)]
public struct _ETW_FILTER_PID
{
    [FieldOffset(0)]
    public uint Count;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public uint[] Pids;
}
