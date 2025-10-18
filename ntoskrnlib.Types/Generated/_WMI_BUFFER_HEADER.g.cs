using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=72)]
public struct _WMI_BUFFER_HEADER
{
    [FieldOffset(0)]
    public uint BufferSize;
    [FieldOffset(4)]
    public uint SavedOffset;
    [FieldOffset(8)]
    public uint CurrentOffset;
    [FieldOffset(12)]
    public int ReferenceCount;
    [FieldOffset(16)]
    public _LARGE_INTEGER TimeStamp;
    [FieldOffset(24)]
    public long SequenceNumber;
    [FieldOffset(32)]
    public _SINGLE_LIST_ENTRY SlistEntry;
    [FieldOffset(32)]
    public IntPtr NextBuffer;
    [FieldOffset(40)]
    public _ETW_BUFFER_CONTEXT ClientContext;
    [FieldOffset(44)]
    public IntPtr State;
    [FieldOffset(48)]
    public uint Offset;
    [FieldOffset(52)]
    public ushort BufferFlag;
    [FieldOffset(54)]
    public ushort BufferType;
    [FieldOffset(56)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public uint[] Padding1;
    [FieldOffset(56)]
    public _ETW_REF_CLOCK ReferenceTime;
    [FieldOffset(56)]
    public _LIST_ENTRY GlobalEntry;
    [FieldOffset(56)]
    public IntPtr Pointer0;
    [FieldOffset(64)]
    public IntPtr Pointer1;
}
