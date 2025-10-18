using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PO_IRP_QUEUE
{
    [FieldOffset(0)]
    public IntPtr CurrentIrp;
    [FieldOffset(8)]
    public IntPtr PendingIrpList;
}
