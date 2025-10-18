using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _HANDLE_TABLE_ENTRY
{
    [FieldOffset(0)]
    public long VolatileLowValue;
    [FieldOffset(0)]
    public long LowValue;
    [FieldOffset(0)]
    public IntPtr InfoTable;
    [FieldOffset(8)]
    public long HighValue;
    [FieldOffset(8)]
    public IntPtr NextFreeHandleEntry;
    [FieldOffset(8)]
    public _EXHANDLE LeafHandleValue;
    [FieldOffset(0)]
    public long RefCountField;
    [FieldOffset(12)]
    public uint Spare2;
}
