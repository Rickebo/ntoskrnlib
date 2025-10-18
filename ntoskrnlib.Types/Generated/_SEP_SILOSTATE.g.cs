using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _SEP_SILOSTATE
{
    [FieldOffset(0)]
    public IntPtr SystemLogonSession;
    [FieldOffset(8)]
    public IntPtr AnonymousLogonSession;
    [FieldOffset(16)]
    public IntPtr AnonymousLogonToken;
    [FieldOffset(24)]
    public IntPtr AnonymousLogonTokenNoEveryone;
    [FieldOffset(32)]
    public IntPtr UncSystemPaths;
    [FieldOffset(40)]
    public IntPtr NgenPaths;
}
