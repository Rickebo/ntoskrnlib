using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=12)]
public struct _PERFINFO_PPM_STATE_SELECTION
{
    [FieldOffset(0)]
    public uint SelectedState;
    [FieldOffset(4)]
    public uint VetoedStates;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public uint[] VetoReason;
}
