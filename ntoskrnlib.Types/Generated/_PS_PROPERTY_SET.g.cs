using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _PS_PROPERTY_SET
{
    [FieldOffset(0)]
    public _LIST_ENTRY ListHead;
    [FieldOffset(16)]
    public ulong Lock;
}
