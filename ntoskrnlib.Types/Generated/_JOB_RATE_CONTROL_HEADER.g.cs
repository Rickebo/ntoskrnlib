using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _JOB_RATE_CONTROL_HEADER
{
    [FieldOffset(0)]
    public IntPtr RateControlQuotaReference;
    [FieldOffset(8)]
    public _RTL_BITMAP OverQuotaHistory;
    [FieldOffset(24)]
    public IntPtr BitMapBuffer;
    [FieldOffset(32)]
    public ulong BitMapBufferSize;
}
