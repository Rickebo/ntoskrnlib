using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _RTL_DRIVE_LETTER_CURDIR
{
    [FieldOffset(0)]
    public ushort Flags;
    [FieldOffset(2)]
    public ushort Length;
    [FieldOffset(4)]
    public uint TimeStamp;
    [FieldOffset(8)]
    public _STRING DosPath;
}
