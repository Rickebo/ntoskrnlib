using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=384)]
public struct _SYMCRYPT_ENTROPY_ACCUMULATOR_STATE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=256)]
    public byte[] buffer;
    [FieldOffset(256)]
    public _KDPC Dpc;
    [FieldOffset(320)]
    public ulong nSamplesAccumulated;
    [FieldOffset(328)]
    public ulong nHealthTestFailures;
    [FieldOffset(336)]
    public IntPtr pCombinedSampleBuffer;
    [FieldOffset(344)]
    public ulong nRawSamples;
    [FieldOffset(352)]
    public uint accumulatorId;
    [FieldOffset(356)]
    public uint nDPCScheduleFailures;
    [FieldOffset(360)]
    public byte dpcInProgress;
}
