using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _EVENT_PAYLOAD_PREDICATE
{
    [FieldOffset(0)]
    public ushort FieldIndex;
    [FieldOffset(2)]
    public ushort CompareOp;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public ulong[] Value;
}
