#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMINPAGE_FLAGS
    {
        [FieldOffset(0)]
        public uint GetExtents;
        [FieldOffset(0)]
        public uint VmType;
        [FieldOffset(0)]
        public uint VaPrefetchReadBlock;
        [FieldOffset(0)]
        public uint CollidedFlowThrough;
        [FieldOffset(0)]
        public uint ForceCollisions;
        [FieldOffset(0)]
        public uint InPageExpanded;
        [FieldOffset(0)]
        public uint IssuedAtLowPriority;
        [FieldOffset(0)]
        public uint FaultFromStore;
        [FieldOffset(0)]
        public uint PagePriority;
        [FieldOffset(0)]
        public uint ClusteredPagePriority;
        [FieldOffset(0)]
        public uint MakeClusterValid;
        [FieldOffset(0)]
        public uint ZeroLastPage;
        [FieldOffset(0)]
        public uint UserFault;
        [FieldOffset(0)]
        public uint StandbyProtectionNeeded;
        [FieldOffset(0)]
        public uint PteChanged;
        [FieldOffset(0)]
        public uint PageFileFault;
        [FieldOffset(0)]
        public uint PageFilePageHashActive;
        [FieldOffset(0)]
        public uint CoalescedIo;
        [FieldOffset(0)]
        public uint VmLockNotNeeded;
        [FieldOffset(0)]
        public uint PartitionReferenced;
        [FieldOffset(0)]
        public uint Spare0;
        [FieldOffset(0)]
        public uint Spare1;
    }
}