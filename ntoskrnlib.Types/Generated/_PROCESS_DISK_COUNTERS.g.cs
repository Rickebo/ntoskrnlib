using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _PROCESS_DISK_COUNTERS
{
    [FieldOffset(0)]
    public ulong BytesRead;
    [FieldOffset(8)]
    public ulong BytesWritten;
    [FieldOffset(16)]
    public ulong ReadOperationCount;
    [FieldOffset(24)]
    public ulong WriteOperationCount;
    [FieldOffset(32)]
    public ulong FlushOperationCount;
}
