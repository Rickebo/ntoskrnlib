using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=192)]
public struct _MMSUPPORT_INSTANCE
{
    [FieldOffset(0)]
    public uint NextPageColor;
    [FieldOffset(4)]
    public uint PageFaultCount;
    [FieldOffset(8)]
    public ulong TrimmedPageCount;
    [FieldOffset(16)]
    public IntPtr VmWorkingSetList;
    [FieldOffset(24)]
    public _LIST_ENTRY WorkingSetExpansionLinks;
    [FieldOffset(40)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public ulong[] AgeDistribution;
    [FieldOffset(104)]
    public IntPtr ExitOutswapGate;
    [FieldOffset(112)]
    public ulong MinimumWorkingSetSize;
    [FieldOffset(120)]
    public ulong MaximumWorkingSetSize;
    [FieldOffset(128)]
    public ulong WorkingSetLeafSize;
    [FieldOffset(136)]
    public ulong WorkingSetLeafPrivateSize;
    [FieldOffset(144)]
    public ulong WorkingSetSize;
    [FieldOffset(152)]
    public ulong WorkingSetPrivateSize;
    [FieldOffset(160)]
    public ulong PeakWorkingSetSize;
    [FieldOffset(168)]
    public uint HardFaultCount;
    [FieldOffset(172)]
    public ushort LastTrimStamp;
    [FieldOffset(174)]
    public ushort PartitionId;
    [FieldOffset(176)]
    public ulong SelfmapLock;
    [FieldOffset(184)]
    public _MMSUPPORT_FLAGS Flags;
    [FieldOffset(188)]
    public uint InterlockedFlags;
}
