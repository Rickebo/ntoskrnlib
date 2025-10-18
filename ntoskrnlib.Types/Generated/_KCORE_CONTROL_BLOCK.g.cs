using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _KCORE_CONTROL_BLOCK
{
    [FieldOffset(0)]
    public byte ProcessorCount;
    [FieldOffset(1)]
    public byte ScanStartIndex;
    [FieldOffset(2)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
    public byte[] Spare;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] Prcbs;
    [FieldOffset(40)]
    public IntPtr CoreControlBlockShadow;
}
