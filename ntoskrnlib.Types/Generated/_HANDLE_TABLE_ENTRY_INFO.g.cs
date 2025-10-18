using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _HANDLE_TABLE_ENTRY_INFO
{
    [FieldOffset(0)]
    public uint AuditMask;
    [FieldOffset(4)]
    public uint MaxRelativeAccessMask;
}
