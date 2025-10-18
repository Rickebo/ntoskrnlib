using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _PPM_COORDINATED_SELECTION
{
    [FieldOffset(0)]
    public uint MaximumStates;
    [FieldOffset(4)]
    public uint SelectedStates;
    [FieldOffset(8)]
    public uint DefaultSelection;
    [FieldOffset(16)]
    public IntPtr Selection;
}
