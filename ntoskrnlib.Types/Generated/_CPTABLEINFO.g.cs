using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _CPTABLEINFO
{
    [FieldOffset(0)]
    public ushort CodePage;
    [FieldOffset(2)]
    public ushort MaximumCharacterSize;
    [FieldOffset(4)]
    public ushort DefaultChar;
    [FieldOffset(6)]
    public ushort UniDefaultChar;
    [FieldOffset(8)]
    public ushort TransDefaultChar;
    [FieldOffset(10)]
    public ushort TransUniDefaultChar;
    [FieldOffset(12)]
    public ushort DBCSCodePage;
    [FieldOffset(14)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=12)]
    public byte[] LeadByte;
    [FieldOffset(32)]
    public IntPtr MultiByteTable;
    [FieldOffset(40)]
    public IntPtr WideCharTable;
    [FieldOffset(48)]
    public IntPtr DBCSRanges;
    [FieldOffset(56)]
    public IntPtr DBCSOffsets;
}
