using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _CRITICAL_PROCESS_EXCEPTION_DATA
{
    [FieldOffset(0)]
    public _GUID ReportId;
    [FieldOffset(16)]
    public _UNICODE_STRING ModuleName;
    [FieldOffset(32)]
    public uint ModuleTimestamp;
    [FieldOffset(36)]
    public uint ModuleSize;
    [FieldOffset(40)]
    public ulong Offset;
}
