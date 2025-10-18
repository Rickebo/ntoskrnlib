using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=36)]
public struct _CM_FULL_RESOURCE_DESCRIPTOR
{
    [FieldOffset(0)]
    public IntPtr InterfaceType;
    [FieldOffset(4)]
    public uint BusNumber;
    [FieldOffset(8)]
    public _CM_PARTIAL_RESOURCE_LIST PartialResourceList;
}
