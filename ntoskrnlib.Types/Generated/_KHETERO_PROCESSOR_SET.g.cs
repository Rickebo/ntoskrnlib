using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _KHETERO_PROCESSOR_SET
{
    [FieldOffset(0)]
    public ulong IdealMask;
    [FieldOffset(8)]
    public ulong PreferredMask;
    [FieldOffset(16)]
    public ulong AvailableMask;
}
