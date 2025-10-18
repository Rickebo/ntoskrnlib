using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _PO_IRP_MANAGER
{
    [FieldOffset(0)]
    public _PO_IRP_QUEUE DeviceIrpQueue;
    [FieldOffset(16)]
    public _PO_IRP_QUEUE SystemIrpQueue;
}
