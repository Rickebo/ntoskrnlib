using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8200)]
public struct _KPRCB_TRACEPOINT_LOG
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=256)]
    public byte[] Entries;
    [FieldOffset(8192)]
    public uint LogIndex;
}
