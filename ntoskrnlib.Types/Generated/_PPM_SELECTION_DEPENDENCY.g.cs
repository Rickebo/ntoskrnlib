using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _PPM_SELECTION_DEPENDENCY
{
    [FieldOffset(0)]
    public uint Processor;
    [FieldOffset(8)]
    public _PPM_SELECTION_MENU Menu;
}
