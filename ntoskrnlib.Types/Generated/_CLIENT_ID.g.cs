using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _CLIENT_ID
{
    [FieldOffset(0)]
    public IntPtr UniqueProcess;
    [FieldOffset(8)]
    public IntPtr UniqueThread;
}
