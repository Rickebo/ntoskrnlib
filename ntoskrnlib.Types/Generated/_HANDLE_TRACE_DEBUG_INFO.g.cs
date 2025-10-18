using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=240)]
public struct _HANDLE_TRACE_DEBUG_INFO
{
    [FieldOffset(0)]
    public int RefCount;
    [FieldOffset(4)]
    public uint TableSize;
    [FieldOffset(8)]
    public uint BitMaskFlags;
    [FieldOffset(16)]
    public _FAST_MUTEX CloseCompactionLock;
    [FieldOffset(72)]
    public uint CurrentStackIndex;
    [FieldOffset(80)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] TraceDb;
}
