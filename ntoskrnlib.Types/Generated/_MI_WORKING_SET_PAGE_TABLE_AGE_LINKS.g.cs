using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _MI_WORKING_SET_PAGE_TABLE_AGE_LINKS
{
    [FieldOffset(0)]
    public int Lock;
    [FieldOffset(4)]
    public uint EntryCount;
    [FieldOffset(8)]
    public IntPtr Flink;
    [FieldOffset(16)]
    public IntPtr Blink;
}
