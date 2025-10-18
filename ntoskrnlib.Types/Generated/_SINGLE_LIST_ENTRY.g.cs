using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _SINGLE_LIST_ENTRY
{
    [FieldOffset(0)]
    public IntPtr Next;
}
