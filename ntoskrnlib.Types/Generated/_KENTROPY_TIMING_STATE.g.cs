using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=344)]
public struct _KENTROPY_TIMING_STATE
{
    [FieldOffset(0)]
    public uint EntropyCount;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=64)]
    public uint[] Buffer;
    [FieldOffset(264)]
    public _KDPC Dpc;
    [FieldOffset(328)]
    public uint LastDeliveredBuffer;
    [FieldOffset(336)]
    public IntPtr ReservedRawDataBuffer;
}
