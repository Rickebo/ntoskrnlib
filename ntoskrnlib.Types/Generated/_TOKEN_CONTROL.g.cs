using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _TOKEN_CONTROL
{
    [FieldOffset(0)]
    public _LUID TokenId;
    [FieldOffset(8)]
    public _LUID AuthenticationId;
    [FieldOffset(16)]
    public _LUID ModifiedId;
    [FieldOffset(24)]
    public _TOKEN_SOURCE TokenSource;
}
