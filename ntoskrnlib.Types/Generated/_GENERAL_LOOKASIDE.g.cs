using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=128)]
public struct _GENERAL_LOOKASIDE
{
    [FieldOffset(0)]
    public _SLIST_HEADER ListHead;
    [FieldOffset(0)]
    public _SINGLE_LIST_ENTRY SingleListHead;
    [FieldOffset(16)]
    public ushort Depth;
    [FieldOffset(18)]
    public ushort MaximumDepth;
    [FieldOffset(20)]
    public uint TotalAllocates;
    [FieldOffset(24)]
    public uint AllocateMisses;
    [FieldOffset(24)]
    public uint AllocateHits;
    [FieldOffset(28)]
    public uint TotalFrees;
    [FieldOffset(32)]
    public uint FreeMisses;
    [FieldOffset(32)]
    public uint FreeHits;
    [FieldOffset(36)]
    public IntPtr Type;
    [FieldOffset(40)]
    public uint Tag;
    [FieldOffset(44)]
    public uint Size;
    [FieldOffset(48)]
    public IntPtr AllocateEx;
    [FieldOffset(48)]
    public IntPtr Allocate;
    [FieldOffset(56)]
    public IntPtr FreeEx;
    [FieldOffset(56)]
    public IntPtr Free;
    [FieldOffset(64)]
    public _LIST_ENTRY ListEntry;
    [FieldOffset(80)]
    public uint LastTotalAllocates;
    [FieldOffset(84)]
    public uint LastAllocateMisses;
    [FieldOffset(84)]
    public uint LastAllocateHits;
    [FieldOffset(88)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public uint[] Future;
}
