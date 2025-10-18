using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _RTL_THREAD_RNG_STATE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public ulong[] State64;
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public uint[] State32;
}
