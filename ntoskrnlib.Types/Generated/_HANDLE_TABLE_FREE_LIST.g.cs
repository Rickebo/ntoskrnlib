using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _HANDLE_TABLE_FREE_LIST
{
    [FieldOffset(0)]
    public _EX_PUSH_LOCK FreeListLock;
    [FieldOffset(8)]
    public IntPtr FirstFreeHandleEntry;
    [FieldOffset(16)]
    public IntPtr LastFreeHandleEntry;
    [FieldOffset(24)]
    public int HandleCount;
    [FieldOffset(28)]
    public uint HighWaterMark;
}
