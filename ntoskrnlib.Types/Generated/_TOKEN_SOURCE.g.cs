using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _TOKEN_SOURCE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public sbyte[] SourceName;
    [FieldOffset(8)]
    public _LUID SourceIdentifier;
}
