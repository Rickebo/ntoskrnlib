using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _PS_CLIENT_SECURITY_CONTEXT
{
    [FieldOffset(0)]
    public ulong ImpersonationData;
    [FieldOffset(0)]
    public IntPtr ImpersonationToken;
}
