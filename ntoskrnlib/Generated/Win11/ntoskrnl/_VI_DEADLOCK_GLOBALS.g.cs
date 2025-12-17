#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 33152)]
    public partial struct _VI_DEADLOCK_GLOBALS
    {
        [FieldOffset(0)]
        public long TimeAcquire;
        [FieldOffset(8)]
        public long TimeRelease;
        [FieldOffset(16)]
        public IntPtr ResourceDatabase;
        [FieldOffset(24)]
        public ulong ResourceDatabaseCount;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1023)]
        public _VF_ADDRESS_RANGE[] ResourceAddressRange;
        [FieldOffset(16400)]
        public IntPtr ThreadDatabase;
        [FieldOffset(16408)]
        public ulong ThreadDatabaseCount;
        [FieldOffset(16416)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1023)]
        public _VF_ADDRESS_RANGE[] ThreadAddressRange;
        [FieldOffset(32784)]
        public uint AllocationFailures;
        [FieldOffset(32788)]
        public uint NodesTrimmedBasedOnAge;
        [FieldOffset(32792)]
        public uint NodesTrimmedBasedOnCount;
        [FieldOffset(32796)]
        public uint NodesSearched;
        [FieldOffset(32800)]
        public uint MaxNodesSearched;
        [FieldOffset(32804)]
        public uint SequenceNumber;
        [FieldOffset(32808)]
        public uint RecursionDepthLimit;
        [FieldOffset(32812)]
        public uint SearchedNodesLimit;
        [FieldOffset(32816)]
        public uint DepthLimitHits;
        [FieldOffset(32820)]
        public uint SearchLimitHits;
        [FieldOffset(32824)]
        public uint StackLimitHits;
        [FieldOffset(32828)]
        public uint ABC_ACB_Skipped;
        [FieldOffset(32832)]
        public uint OutOfOrderReleases;
        [FieldOffset(32836)]
        public uint NodesReleasedOutOfOrder;
        [FieldOffset(32840)]
        public uint TotalReleases;
        [FieldOffset(32844)]
        public uint RootNodesDeleted;
        [FieldOffset(32848)]
        public uint ForgetHistoryCounter;
        [FieldOffset(32856)]
        public IntPtr Instigator;
        [FieldOffset(32864)]
        public uint NumberOfParticipants;
        [FieldOffset(32872)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public IntPtr[] Participant;
        [FieldOffset(33128)]
        public int ChildrenCountWatermark;
        [FieldOffset(33132)]
        public uint StackType;
        [FieldOffset(33136)]
        public ulong StackLowLimit;
        [FieldOffset(33144)]
        public ulong StackHighLimit;
    }
}