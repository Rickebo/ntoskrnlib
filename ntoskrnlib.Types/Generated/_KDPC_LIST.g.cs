using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KDPC_LIST
{
    [FieldOffset(0)]
    public _SINGLE_LIST_ENTRY ListHead;
    [FieldOffset(8)]
    public IntPtr LastEntry;
}
