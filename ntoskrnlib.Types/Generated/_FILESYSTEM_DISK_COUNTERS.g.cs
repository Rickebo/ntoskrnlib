using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _FILESYSTEM_DISK_COUNTERS
{
    [FieldOffset(0)]
    public ulong FsBytesRead;
    [FieldOffset(8)]
    public ulong FsBytesWritten;
}
