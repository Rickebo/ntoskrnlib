using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PPM_SELECTION_MENU
{
    [FieldOffset(0)]
    public uint Count;
    [FieldOffset(8)]
    public IntPtr Entries;
}
