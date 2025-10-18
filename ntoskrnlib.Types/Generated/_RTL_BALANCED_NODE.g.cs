using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _RTL_BALANCED_NODE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] Children;
    [FieldOffset(0)]
    public IntPtr Left;
    [FieldOffset(8)]
    public IntPtr Right;
    [FieldOffset(16)]
    public ulong ParentValue;
}
