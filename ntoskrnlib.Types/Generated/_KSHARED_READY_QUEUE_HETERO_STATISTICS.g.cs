using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=896)]
public struct _KSHARED_READY_QUEUE_HETERO_STATISTICS
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public byte[] ExpectedRuntimeByClass;
}
