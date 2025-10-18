using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KHETRO_HWFEEDBACK_TYPE
{
    [FieldOffset(0)]
    public uint Count;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] HwFeedbackClass;
}
