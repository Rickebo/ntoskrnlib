using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=272)]
public struct _PROCESS_ENERGY_VALUES
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] Cycles;
    [FieldOffset(64)]
    public ulong DiskEnergy;
    [FieldOffset(72)]
    public ulong NetworkTailEnergy;
    [FieldOffset(80)]
    public ulong MBBTailEnergy;
    [FieldOffset(88)]
    public ulong NetworkTxRxBytes;
    [FieldOffset(96)]
    public ulong MBBTxRxBytes;
    [FieldOffset(104)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] Durations;
    [FieldOffset(104)]
    public _ENERGY_STATE_DURATION ForegroundDuration;
    [FieldOffset(112)]
    public _ENERGY_STATE_DURATION DesktopVisibleDuration;
    [FieldOffset(120)]
    public _ENERGY_STATE_DURATION PSMForegroundDuration;
    [FieldOffset(128)]
    public uint CompositionRendered;
    [FieldOffset(132)]
    public uint CompositionDirtyGenerated;
    [FieldOffset(136)]
    public uint CompositionDirtyPropagated;
    [FieldOffset(140)]
    public uint Reserved1;
    [FieldOffset(144)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] AttributedCycles;
    [FieldOffset(208)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] WorkOnBehalfCycles;
}
