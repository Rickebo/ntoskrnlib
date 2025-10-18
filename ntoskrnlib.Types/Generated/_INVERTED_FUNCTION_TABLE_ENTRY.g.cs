using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _INVERTED_FUNCTION_TABLE_ENTRY
{
    [FieldOffset(0)]
    public IntPtr FunctionTable;
    [FieldOffset(0)]
    public IntPtr DynamicTable;
    [FieldOffset(8)]
    public IntPtr ImageBase;
    [FieldOffset(16)]
    public uint SizeOfImage;
    [FieldOffset(20)]
    public uint SizeOfTable;
}
