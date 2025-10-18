using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=160)]
public struct _PROCESSOR_PROFILE_CONTROL_AREA
{
    [FieldOffset(0)]
    public _PEBS_DS_SAVE_AREA PebsDsSaveArea;
    [FieldOffset(0)]
    public IntPtr RawBuffer;
}
