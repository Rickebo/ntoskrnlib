using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=96)]
public struct _POP_FX_ACTIVE_TIME_ACCOUNTING
{
    [FieldOffset(0)]
    public ulong Total;
    [FieldOffset(8)]
    public ulong Unattributed;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public ulong[] Buckets;
    [FieldOffset(56)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public ulong[] PerBucket;
}
