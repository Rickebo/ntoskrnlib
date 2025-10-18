using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=104)]
public struct _KLOCK_ENTRIES
{
    [FieldOffset(0)]
    public IntPtr Thread;
    [FieldOffset(8)]
    public ushort AvailableEntryBitmap;
    [FieldOffset(10)]
    public ushort OrphanedEntryBitmap;
    [FieldOffset(12)]
    public byte EntryCount;
    [FieldOffset(13)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] Padding0;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Entries;
}
