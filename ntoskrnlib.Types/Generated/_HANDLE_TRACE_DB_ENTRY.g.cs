using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=160)]
public struct _HANDLE_TRACE_DB_ENTRY
{
    [FieldOffset(0)]
    public _CLIENT_ID ClientId;
    [FieldOffset(16)]
    public IntPtr Handle;
    [FieldOffset(24)]
    public uint Type;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public byte[] StackTrace;
}
