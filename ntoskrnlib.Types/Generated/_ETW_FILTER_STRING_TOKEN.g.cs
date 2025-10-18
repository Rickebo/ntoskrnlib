using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _ETW_FILTER_STRING_TOKEN
{
    [FieldOffset(0)]
    public ushort Count;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Tokens;
}
