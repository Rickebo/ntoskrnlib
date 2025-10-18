using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=20)]
public struct _CM_PARTIAL_RESOURCE_DESCRIPTOR
{
    [FieldOffset(0)]
    public byte Type;
    [FieldOffset(1)]
    public byte ShareDisposition;
    [FieldOffset(2)]
    public ushort Flags;
    [FieldOffset(4)]
    public _unnamed_tag_ u;
}
