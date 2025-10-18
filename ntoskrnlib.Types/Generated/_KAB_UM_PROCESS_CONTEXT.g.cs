using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KAB_UM_PROCESS_CONTEXT
{
    [FieldOffset(0)]
    public IntPtr Trees;
    [FieldOffset(8)]
    public uint TreeCount;
}
