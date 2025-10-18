using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KMCE_RECOVERY_CONTEXT
{
    [FieldOffset(0)]
    public uint Flags;
    [FieldOffset(4)]
    public uint Reserved;
    [FieldOffset(8)]
    public ulong PhysicalAddress;
    [FieldOffset(8)]
    public IntPtr Record;
}
