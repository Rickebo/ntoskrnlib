using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PO_DIAG_STACK_RECORD
{
    [FieldOffset(0)]
    public uint StackDepth;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Stack;
}
