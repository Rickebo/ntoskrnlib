using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=84)]
public struct _IOP_IRP_STACK_PROFILER
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=20)]
    public uint[] Profile;
    [FieldOffset(80)]
    public uint TotalIrps;
}
