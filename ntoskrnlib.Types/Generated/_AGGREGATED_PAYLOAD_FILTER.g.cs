using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=80)]
public struct _AGGREGATED_PAYLOAD_FILTER
{
    [FieldOffset(2)]
    public ushort Size;
    [FieldOffset(4)]
    public ushort PredicateCount;
    [FieldOffset(6)]
    public ushort Reserved;
    [FieldOffset(8)]
    public ulong HashedEventIdBitmap;
    [FieldOffset(16)]
    public _GUID ProviderGuid;
    [FieldOffset(32)]
    public ushort EachEventTableOffset;
    [FieldOffset(34)]
    public ushort EachEventTableLength;
    [FieldOffset(36)]
    public ushort PayloadDecoderTableOffset;
    [FieldOffset(38)]
    public ushort PayloadDecoderTableLength;
    [FieldOffset(40)]
    public ushort EventFilterTableOffset;
    [FieldOffset(42)]
    public ushort EventFilterTableLength;
    [FieldOffset(44)]
    public ushort UNICODEStringTableOffset;
    [FieldOffset(46)]
    public ushort UNICODEStringTableLength;
    [FieldOffset(48)]
    public ushort ANSIStringTableOffset;
    [FieldOffset(50)]
    public ushort ANSIStringTableLength;
    [FieldOffset(56)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] PredicateTable;
}
