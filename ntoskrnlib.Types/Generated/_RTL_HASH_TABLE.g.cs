using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _RTL_HASH_TABLE
{
    [FieldOffset(0)]
    public uint EntryCount;
    [FieldOffset(8)]
    public IntPtr Buckets;
}
