using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION
{
    [FieldOffset(0)]
    public uint SecurityAttributeCount;
    [FieldOffset(8)]
    public _LIST_ENTRY SecurityAttributesList;
    [FieldOffset(24)]
    public uint WorkingSecurityAttributeCount;
    [FieldOffset(32)]
    public _LIST_ENTRY WorkingSecurityAttributesList;
}
