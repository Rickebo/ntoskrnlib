using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=72)]
public struct _SECURITY_CLIENT_CONTEXT
{
    [FieldOffset(0)]
    public _SECURITY_QUALITY_OF_SERVICE SecurityQos;
    [FieldOffset(16)]
    public IntPtr ClientToken;
    [FieldOffset(24)]
    public byte DirectlyAccessClientToken;
    [FieldOffset(25)]
    public byte DirectAccessEffectiveOnly;
    [FieldOffset(26)]
    public byte ServerIsRemote;
    [FieldOffset(28)]
    public _TOKEN_CONTROL ClientTokenControl;
}
