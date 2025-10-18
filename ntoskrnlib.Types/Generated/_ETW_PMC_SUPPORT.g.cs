using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _ETW_PMC_SUPPORT
{
    [FieldOffset(0)]
    public IntPtr Source;
    [FieldOffset(8)]
    public uint HookIdCount;
    [FieldOffset(12)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public ushort[] HookId;
    [FieldOffset(20)]
    public uint CountersCount;
    [FieldOffset(24)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] ProcessorCtrs;
}
